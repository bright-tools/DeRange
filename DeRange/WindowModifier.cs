using System.Collections.Generic;
using Win32Interop.WinHandles;

namespace DeRange
{
    class WindowModifier
    {
        static public void ApplyModification(Config.Window p_win, Config.Location p_pos)
        {
            IEnumerable<WindowHandle> currentWindows = TopLevelWindowUtils.FindWindows(w => (w.IsVisible() == true) && (w.GetWindowText() != ""));
            foreach (WindowHandle windowHandle in currentWindows)
            {
                bool matches = false;
                if (p_win.m_matchWindowClass)
                {
                    if (p_win.m_windowClass.Equals(windowHandle.GetClassName()))
                    {
                        matches = true;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (matches)
                {
                    if (p_pos.XYPosEnabled)
                    {
                        windowHandle.SetWindowXY(p_pos.XPos, p_pos.YPos);
                    }
                    if (p_pos.SizeEnabled)
                    {
                        windowHandle.SetWindowSize(p_pos.Width, p_pos.Height);
                    }
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
