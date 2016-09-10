using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace DeRange.Config
{
    public class ParentItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Guid mp_guid;
        [XmlElement(ElementName = "GUID")]
        public Guid GUID
        {
            get { return mp_guid; }
            set
            {
                if (mp_guid != value)
                {
                    mp_guid = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ParentItem()
        {
            GUID = Guid.NewGuid();
        }

        virtual protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
