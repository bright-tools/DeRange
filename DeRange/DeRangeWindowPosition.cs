using System;
using System.Xml.Serialization;
using Win32Interop.WinHandles;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace DeRange
{
    [Serializable]
    [XmlRoot(ElementName = "DeRangeWindowPosition")]
    public class DeRangeWindowPosition : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int mp_xpos;
        [XmlElement(ElementName = "XPos")]
        public int xPos {
            get { return mp_xpos; }
            set
            {
                if (mp_xpos != value)
                {
                    mp_xpos = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int mp_ypos;
        [XmlElement(ElementName = "YPos")]
        public int yPos
        {
            get { return mp_ypos; }
            set
            {
                if (mp_ypos != value)
                {
                    mp_ypos = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mp_xyposEnabled;
        [XmlElement(ElementName = "XYPosEnabled")]
        public bool xyPosEnabled
        {
            get { return mp_xyposEnabled; }
            set
            {
                if (mp_xyposEnabled != value)
                {
                    mp_xyposEnabled = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
