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
        public int XPos {
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
        public int YPos
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
        public bool XYPosEnabled
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

        private int mp_height;
        [XmlElement(ElementName = "Height")]
        public int Height
        {
            get { return mp_height; }
            set
            {
                if (mp_height != value)
                {
                    mp_height = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int mp_width;
        [XmlElement(ElementName = "Width")]
        public int Width
        {
            get { return mp_width; }
            set
            {
                if (mp_width != value)
                {
                    mp_width = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mp_sizeEnabled;
        [XmlElement(ElementName = "SizeEnabled")]
        public bool SizeEnabled
        {
            get { return mp_sizeEnabled; }
            set
            {
                if (mp_sizeEnabled != value)
                {
                    mp_sizeEnabled = value;
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
