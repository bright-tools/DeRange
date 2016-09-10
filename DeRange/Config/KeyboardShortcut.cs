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
    }
}
