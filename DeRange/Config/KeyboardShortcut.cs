using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DeRange.Config
{
    [Serializable]
    [XmlRoot(ElementName = "KeyboardShortcut")]
    public class KeyboardShortcut
    {
        public bool ShiftModifier { get; set; }
        public bool CtrlModifier { get; set; }
        public bool AltModifier { get; set; }
        public bool WinModifier { get; set; }
        public Keys Key { get; set; }
        public KeyModifier KeyModifier
        {
            get
            {
                KeyModifier mod = KeyModifier.None;

                if (AltModifier)
                {
                    mod |= KeyModifier.Alt;
                }
                if (WinModifier)
                {
                    mod |= KeyModifier.Win;
                }
                if (ShiftModifier)
                {
                    mod |= KeyModifier.Shift;
                }
                if (CtrlModifier)
                {
                    mod |= KeyModifier.Ctrl;
                }

                return mod;
            }
        }
    }
}
