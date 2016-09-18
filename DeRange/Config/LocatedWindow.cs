using System;
using System.Xml.Serialization;

namespace DeRange.Config
{
    [Serializable]
    [XmlRoot(ElementName = "LocatedWindow")]
    public class LocatedWindow : ChangeItem
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

        private bool mp_allowMultipleMatches;
        [XmlElement(ElementName = "AllowMultipleMatches")]
        public bool AllowMultipleMatches
        {
            get { return mp_allowMultipleMatches; }
            set
            {
                if (mp_allowMultipleMatches != value)
                {
                    mp_allowMultipleMatches = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public override string ToString()
        {
            Object locObj = Registry<ParentItem>.Query(LocationGUID);
            Object winObj = Registry<ParentItem>.Query(WindowGUID);
            string retVal = base.ToString();

            if(( locObj.GetType() == typeof( Location )) &&
               ( winObj.GetType() == typeof( Window )))
            {
                Window win = (Window)winObj;
                Location loc = (Location)locObj;

                retVal = win.ToString() + " @ " + loc.StringOf;

                if( AllowMultipleMatches )
                {
                    retVal += " [Multiple]";
                }
            }
            return retVal;
        }
    }
}
