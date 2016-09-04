using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win32Interop.WinHandles;

namespace DeRange
{
    class DeRangeWindowModifier
    {
        static public void ApplyModification(DeRangeWindowConfiguration p_win, DeRangeWindowPosition p_pos)
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
                        break;
                    }
                }

                if (matches)
                {
                    if (p_pos.xyPosEnabled)
                    {
                        windowHandle.SetWindowXY(p_pos.xPos, p_pos.yPos);
                    }
                }
            }
        }
    }
}
