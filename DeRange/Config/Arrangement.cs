using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
