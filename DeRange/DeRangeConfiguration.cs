﻿using System;
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

        public DeRangeConfiguration()
        {
        }

        [XmlElement(ElementName = "WindowPositions")]
        public BindingList<DeRangeWindowPosition> m_windowPositions = new BindingList<DeRangeWindowPosition>();

        private BindingList<DeRangeWindowConfiguration> p_windowConfigurations = new BindingList<DeRangeWindowConfiguration>();
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

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
