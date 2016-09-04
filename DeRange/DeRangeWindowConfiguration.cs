using System;
using System.Xml.Serialization;
using Win32Interop.WinHandles;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace DeRange
{
    [Serializable]
    [XmlRoot(ElementName = "DeRangeWindowConfiguration")]
    public class DeRangeWindowConfiguration : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private string mp_windowTitle;
        [XmlElement(ElementName = "WindowTitle")]
        public String m_windowTitle {
            get { return mp_windowTitle; }
            set
            {
                if (mp_windowTitle != value)
                {
                    mp_windowTitle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        [XmlElement(ElementName = "ElementName")]
        public String m_processName { get; set; }
        [XmlElement(ElementName = "ProcessFile")]
        public String m_processFile { get; set; }
        [XmlElement(ElementName = "WindowClass")]
        public String m_windowClass { get; set; }

        public DeRangeWindowConfiguration()
        {

        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public DeRangeWindowConfiguration(WindowHandle p_windowHandle)
        {
            m_windowTitle = p_windowHandle.GetWindowText();
            m_windowClass = p_windowHandle.GetClassName();
        }
    }
}
