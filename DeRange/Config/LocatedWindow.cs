using System;
using System.Xml.Serialization;

namespace DeRange.Config
{
    [Serializable]
    [XmlRoot(ElementName = "LocatedWindow")]
    public class LocatedWindow
    {
        public LocatedWindow()
        {
        }

        [XmlElement(ElementName = "LocationGUID")]
        public Guid LocationGUID
        {
            get;
            set;
        } = Guid.Empty;

        [XmlElement(ElementName = "WindowGUID")]
        public Guid WindowGUID
        {
            get;
            set;
        } = Guid.Empty;

        public String StringOf( Top p_top )
        {
            Location loc = p_top.GetLocation(LocationGUID);
            Window win = p_top.GetWindow(WindowGUID);

            return win + " @ " + loc;
        }
    }
}
