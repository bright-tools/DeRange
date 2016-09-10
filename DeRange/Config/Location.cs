using System;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using Win32Interop.WinHandles;
using System.ComponentModel;

namespace DeRange.Config
{
    [Serializable]
    [XmlRoot(ElementName = "Location")]
    public class Location : ParentItem
    {
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

        private String mp_name = "";
        [XmlElement(ElementName = "Name")]
        public String Name
        {
            get { return mp_name; }
            set
            {
                if (mp_name != value)
                {
                    mp_name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        [TypeConverter(typeof(EnumDescriptionTypeConverter))]
        public enum WindowStatus
        {
            [Description("Located")]
            Located,
            [Description("Minimized")]
            Minimised,
            [Description("Maximized")]
            Maximised,
            [Description("Don't Change")]
            NoChange,
        }

        private WindowStatus mp_status;
        [XmlElement(ElementName = "Status")]
        public WindowStatus Status
        {
            get { return mp_status; }
            set
            {
                if (mp_status != value)
                {
                    mp_status = value;
                    NotifyPropertyChanged();
                }
            }
        }

        [XmlIgnore]
        public String StringOf
        {
            get
            {
                String retVal;
                if( Name.Length > 0 )
                {
                    retVal = Name;
                }
                else
                {
                    retVal = "";
                    if(XYPosEnabled )
                    {
                        retVal += "X: " + XPos + " Y: " + YPos;
                    }
                    if (SizeEnabled)
                    {
                        if( retVal.Length > 0 )
                        {
                            retVal += " ";
                        }
                        retVal += "W: " + Width + " H: " + Height;
                    }
                    if( retVal.Length == 0)
                    {
                        retVal = "(empty)";
                    }
                }
                return retVal;
            }
        }

        new protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            base.NotifyPropertyChanged(propertyName);
            base.NotifyPropertyChanged("StringOf");
        }

        public void UpdateFrom(WindowHandle p_windowHandle)
        {
            WindowHandleExtensions.WINDOWPLACEMENT placement = new WindowHandleExtensions.WINDOWPLACEMENT();
            p_windowHandle.GetWindowPlacement(ref placement);

            XPos = placement.rcNormalPosition.left;
            YPos = placement.rcNormalPosition.top;
            Width = placement.rcNormalPosition.right - XPos;
            Height = placement.rcNormalPosition.bottom - YPos;
        }
    }
}
