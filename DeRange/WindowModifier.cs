using System.Collections.Generic;
using System.Windows.Forms;
using Win32Interop.WinHandles;

namespace DeRange
{
    class WindowModifier
    {
        static public void ApplyArrangement(Config.Top p_config, Config.Arrangement p_arrangement)
        {
            foreach (Config.LocatedWindow locWin in p_arrangement.WindowPositions )
            {
                ApplyLocatedWindow(p_config,locWin);
            }
        }

        static public void ApplyLocatedWindow(Config.Top p_config, Config.LocatedWindow p_locatedWindow )
        {
            Config.Location loc = p_config.GetLocation(p_locatedWindow.LocationGUID);
            Config.Window win = p_config.GetWindow(p_locatedWindow.WindowGUID);

            ApplyModification(win, loc);
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

            /* Is the mid-point on the specified screen? */
            return (midx >= p_screen.WorkingArea.Left) && (midx =< p_screen.WorkingArea.Right) &&
                   (midy >= p_screen.WorkingArea.Top) && (midy =< p_screen.WorkingArea.Bottom);
        }

        static public void ApplyModification(Config.Window p_win, Config.Location p_pos)
        {
            IEnumerable<WindowHandle> currentWindows = TopLevelWindowUtils.FindWindows(w => (w.IsVisible() == true) && (w.GetWindowText() != ""));
            foreach (WindowHandle windowHandle in currentWindows)
            {
                if (p_win.IsMatchFor(windowHandle))
                {
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
                }
            }
        }
    }
}
