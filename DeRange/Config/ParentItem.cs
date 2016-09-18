using System;
using System.Xml.Serialization;

namespace DeRange.Config
{
    public class ParentItem : ChangeItem
    {
        private Guid mp_guid;
        [XmlElement(ElementName = "GUID")]
        public Guid GUID
        {
            get { return mp_guid; }
            set
            {
                if (mp_guid != value)
                {
                    Registry<ParentItem>.UnRegister(this);

                    mp_guid = value;

                    Registry<ParentItem>.Register(this);

                    NotifyPropertyChanged();
                }
            }
        }

        public ParentItem()
        {
            GUID = Guid.NewGuid();
        }
    }
}
