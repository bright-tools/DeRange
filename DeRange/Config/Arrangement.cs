using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace DeRange.Config
{
    [Serializable]
    [XmlRoot(ElementName = "Arrangement")]
    public class Arrangement : ParentItem
    {
        public Arrangement() : base()
        {
            Name = "New";
        }

        [XmlElement(ElementName = "KeyboardShortcut")]
        public KeyboardShortcut Shortcut
        { get; set; } = new KeyboardShortcut();

        [XmlElement(ElementName = "Name")]
        public String Name
        { get; set; }

        [XmlElement(ElementName = "WindowPositions")]
        public BindingList<LocatedWindow> WindowPositions = new BindingList<LocatedWindow>();

        [XmlIgnore]
        public String StringOf
        {
            get { return Name; }
        }
        }
    }
