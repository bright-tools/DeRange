using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace DeRange.Config
{
    [Serializable]
    [XmlRoot(ElementName = "Arrangement")]
    public class Arrangement : ParentItem
    {

        [TypeConverter(typeof(EnumDescriptionTypeConverter))]
        public enum NonMatchingStatus
        {
            [Description("Don't Change")]
            NoChange,
            [Description("Minimized")]
            Minimised,
            [Description("Move Behind")]
            MoveBehind,
        }

        public Arrangement() : base()
        {
            Name = "New";
        }

        [XmlElement(ElementName = "KeyboardShortcut")]
        public KeyboardShortcut Shortcut
        { get; set; } = new KeyboardShortcut();

        private string mp_name;
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

        [XmlElement(ElementName = "WindowPositions")]
        public BindingList<LocatedWindow> WindowPositions = new BindingList<LocatedWindow>();

        [XmlIgnore]
        public String StringOf
        {
            get { return Name; }
        }

        private bool mp_setZIndex;
        [XmlElement(ElementName = "SetZIndex")]
        public bool SetZIndex
        {
            get { return mp_setZIndex; }
            set
            {
                if (mp_setZIndex != value)
                {
                    mp_setZIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }

        NonMatchingStatus np_nonMatchingWindowStatus = NonMatchingStatus.NoChange;
        [XmlElement(ElementName = "NonMatchingWindowStatus")]
        public NonMatchingStatus NonMatchingWindowStatus
        {
            get { return np_nonMatchingWindowStatus; }
            set
            {
                if (np_nonMatchingWindowStatus != value)
                {
                    np_nonMatchingWindowStatus = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
