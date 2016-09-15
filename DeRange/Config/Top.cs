using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;

namespace DeRange.Config
{
    [Serializable]
    [XmlRoot(ElementName = "DeRangeConfiguration")]
    public class Top : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Top()
        {
        }

        [XmlElement(ElementName = "Arrangements")]
        public BindingList<Arrangement> Arrangements = new BindingList<Arrangement>();

        [XmlElement(ElementName = "WindowPositions")]
        public BindingList<Location> WindowPositions = new BindingList<Location>();

        private BindingList<Window> p_windowConfigurations = new BindingList<Window>();
        [XmlArray(ElementName = "WindowConfigurations")]
        public BindingList<Window> WindowConfigurations
        {
            get
            {
                return p_windowConfigurations;
            }
            set
            {
                if( p_windowConfigurations != value )
                {
                    p_windowConfigurations = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Window GetWindow(Guid p_guid)
        {
            return WindowConfigurations.SingleOrDefault(d => d.GUID == p_guid);
        }

        public Location GetLocation( Guid p_guid )
        {
            return WindowPositions.SingleOrDefault(d => d.GUID == p_guid);
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
