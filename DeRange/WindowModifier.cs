using System.Collections.Generic;
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

        static public void ApplyModification(Config.Window p_win, Config.Location p_pos)
        {
            IEnumerable<WindowHandle> currentWindows = TopLevelWindowUtils.FindWindows(w => (w.IsVisible() == true) && (w.GetWindowText() != ""));
            foreach (WindowHandle windowHandle in currentWindows)
            {
                if (p_win.IsMatchFor(windowHandle))
                {
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
