﻿using System;
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
            }
        }
    }
}
