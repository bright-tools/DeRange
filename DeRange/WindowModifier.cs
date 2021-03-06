﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Win32Interop.WinHandles;
using System;
using static Win32Interop.WinHandles.TopLevelWindowUtils;

namespace DeRange
{
    class WindowModifier
    {
        static private void HandleNonMatchingWindows(Config.Arrangement p_arrangement, HashSet<WindowHandle> p_matched)
        {
            if (p_arrangement.NonMatchingWindowStatus != Config.Arrangement.NonMatchingStatus.NoChange)
            {
                /* Get all the visible windows */
                HashSet<WindowHandle> allWindows = new HashSet<WindowHandle>(GetAllVisibleWindows());

                /* Remove those we previously matched */
                allWindows.ExceptWith(p_matched);

                /* Apply appropriate change to each of the non-matched windows */
                foreach (WindowHandle wHand in allWindows)
                {
                    switch (p_arrangement.NonMatchingWindowStatus)
                    {
                        case Config.Arrangement.NonMatchingStatus.Minimised:
                            wHand.MinimizeWindow();
                            break;
                        case Config.Arrangement.NonMatchingStatus.MoveBehind:
                            wHand.SetZPosition((IntPtr)(1));
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        static public void ApplyArrangement(Config.Top p_config, Config.Arrangement p_arrangement)
        {
            HashSet<WindowHandle> matchedWindows = new HashSet<WindowHandle>();
            IntPtr hwnd = IntPtr.Zero;

            foreach (Config.LocatedWindow locWin in p_arrangement.WindowPositions)
            {
                HashSet<WindowHandle> thisLocWinMatches = ApplyLocatedWindow(p_config, locWin, matchedWindows);

                if (p_arrangement.SetZIndex)
                {
                    foreach (WindowHandle wHand in thisLocWinMatches)
                    {
                        wHand.SetZPosition(hwnd);
                        hwnd = wHand.RawPtr;
                    }
                }

                matchedWindows.UnionWith(thisLocWinMatches);
            }

            HandleNonMatchingWindows(p_arrangement, matchedWindows);
        }

        static public HashSet<WindowHandle> ApplyLocatedWindow(Config.Top p_config, Config.LocatedWindow p_locatedWindow, HashSet<WindowHandle> p_exclude = null)
        {
            Config.Location loc = p_config.GetLocation(p_locatedWindow.LocationGUID);
            Config.Window win = p_config.GetWindow(p_locatedWindow.WindowGUID);

            return ApplyModification(win, loc, p_locatedWindow.AllowMultipleMatches, p_exclude);
        }

        static public bool IsWindowOnScreen( WindowHandle p_handle, Screen p_screen )
        {
            WindowHandleExtensions.WINDOWPLACEMENT placement = new WindowHandleExtensions.WINDOWPLACEMENT();
            p_handle.GetWindowPlacement(ref placement);

            /* Work out where the mid-point of the window is.  The screen on which the midpoint resides will be
             * the one on which the window maximises */
            int width = placement.rcNormalPosition.right - placement.rcNormalPosition.left;
            int height = placement.rcNormalPosition.bottom- placement.rcNormalPosition.top;

            int midx = placement.rcNormalPosition.left + (width / 2);
            int midy = placement.rcNormalPosition.top + (height / 2);

            Point midPoint = new Point(midx, midy);

            /* Is the mid-point on the specified screen? */
            return p_screen.WorkingArea.Contains(midPoint);
        }

        static public IEnumerable<WindowHandle> GetAllVisibleWindows()
        {
            return TopLevelWindowUtils.FindWindows(w => (w.IsVisible() == true) && (w.GetWindowText() != ""), FindWindowSortType.SortByWinHandle);
        }

        static public HashSet<WindowHandle> ApplyModification(Config.Window p_win, Config.Location p_pos, bool p_allowMultiple, HashSet<WindowHandle> p_exclude = null)
        {
            HashSet<WindowHandle> matches = new HashSet<WindowHandle>();
            IEnumerable<WindowHandle> currentWindows = GetAllVisibleWindows();
            foreach (WindowHandle windowHandle in currentWindows)
            {
                if (((p_exclude == null) || !(p_exclude.Contains(windowHandle))) && p_win.IsMatchFor(windowHandle))
                {
                    matches.Add(windowHandle);

                    /* If it's a positioned or sized window and it's currently maximised or minimised, then restore it
                     * prior to applying the position/sizing */
                    if(p_pos.XYPosEnabled || p_pos.SizeEnabled || (p_pos.Status == Config.Location.WindowStatus.Maximised))
                    {
                        WindowHandleExtensions.WINDOWPLACEMENT placement = new WindowHandleExtensions.WINDOWPLACEMENT();
                        windowHandle.GetWindowPlacement(ref placement);

                        switch( placement.showCmd )
                        {
                            case WindowHandleExtensions.WindowShowStyle.Maximize:
                            case WindowHandleExtensions.WindowShowStyle.ShowMinimized:
                                windowHandle.RestoreWindow();
                                break;
                        }
                    }

                    if (p_pos.XYPosEnabled)
                    {
                        windowHandle.SetWindowXY(p_pos.XPos, p_pos.YPos);
                    }
                    if (p_pos.SizeEnabled)
                    {
                        windowHandle.SetWindowSize(p_pos.Width, p_pos.Height);
                    }

                    switch( p_pos.Status )
                    {
                        case Config.Location.WindowStatus.Maximised:
                            if (p_pos.MaximiseScreen < Screen.AllScreens.Length)
                            {
                                Screen screen = Screen.AllScreens[p_pos.MaximiseScreen];

                                /* If the window is not on the screen to which it's specified to maximise,
                                 * move it */
                                if (!IsWindowOnScreen(windowHandle, screen))
                                {
                                    windowHandle.SetWindowXY(screen.WorkingArea.Left,
                                                             screen.WorkingArea.Top );
                                    windowHandle.SetWindowSize(screen.WorkingArea.Right - screen.WorkingArea.Left,
                                                               screen.WorkingArea.Bottom - screen.WorkingArea.Top);
                                }
                            }
                            windowHandle.MaximizeWindow();
                            break;
                        case Config.Location.WindowStatus.Minimised:
                            windowHandle.MinimizeWindow();
                            break;
                        case Config.Location.WindowStatus.Located:
                            windowHandle.ShowWindow();
                            break;

                        default:
                            break;
                    }

                    if( !p_allowMultiple )
                    {
                        break;
                    }
                }
            }
            return matches;
        }
    }
}
