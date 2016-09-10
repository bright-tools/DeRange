using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
