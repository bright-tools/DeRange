using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DeRange
{
    [Serializable]
    [XmlRoot(ElementName = "DeRangeConfiguration")]
    public class DeRangeConfiguration : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BindingList<DeRangeWindowConfiguration> p_windowConfigurations = new BindingList<DeRangeWindowConfiguration>();

        [XmlElement(ElementName = "WindowPositions")]
        public BindingList<DeRangeWindowPosition> m_windowPositions = new BindingList<DeRangeWindowPosition>();

        [XmlArray("WindowConfigurations")]
        public BindingList<DeRangeWindowConfiguration> windowConfigurations
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

        public DeRangeConfiguration()
        {
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
