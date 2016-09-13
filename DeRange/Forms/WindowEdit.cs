using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DeRange.Forms
{
    public partial class WindowEdit : ParentForm
    {
        public  Config.Top      m_config;

        protected override System.Drawing.Size WindowSettingSize
        {
            get
            {
                return Properties.Settings.Default.WindowEditSize;
            }
            set
            {
                Properties.Settings.Default.WindowEditSize = value;
            }
        }

        protected override System.Windows.Forms.FormWindowState WindowSettingState
        {
            get
            {
                return Properties.Settings.Default.WindowEditState;
            }
            set
            {
                Properties.Settings.Default.WindowEditState = value;
            }
        }

        protected override System.Drawing.Point WindowSettingLocation
        {
            get
            {
                return Properties.Settings.Default.WindowEditLocation;
            }
            set
            {
                Properties.Settings.Default.WindowEditLocation = value;
            }
        }

        public WindowEdit(Config.Top p_config)
        {
            m_config = p_config;

            InitializeComponent();

            this.windowConfigurationsBindingSource.DataSource = m_config.WindowConfigurations;

            if(m_config.WindowConfigurations.Count > 0)
            {
                windowConfigListBox.SelectedItem = m_config.WindowConfigurations[0];
            }

            m_config.WindowConfigurations.ListChanged += windowConfigurationListChanged;

            updateButtonStatuses();
        }

        private void updateButtonStatuses()
        {
            removeButton.Enabled = (m_config.WindowConfigurations.Count > 0);
        }

        void windowConfigurationListChanged(object sender, ListChangedEventArgs e)
        {
            updateButtonStatuses();
        }

        private void SetConfigurationEditEnabled( bool p_enabled )
        {
            captureButton.Enabled = p_enabled;
            
            windowNameTextbox.Enabled = p_enabled;
            windowClassTextbox.Enabled = p_enabled;
            processFileTextbox.Enabled = p_enabled;
            processFileMatchEnabledCheckbox.Enabled = p_enabled;
            windowNameMatchEnabledCheckbox.Enabled = p_enabled;
            windowClassMatchEnabledCheckbox.Enabled = p_enabled;
            processFileAsRegexCheckbox.Enabled = p_enabled;
            windowNameIsRegexCheckbox.Enabled = p_enabled;
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            Forms.ActiveWindowSelector selector = new Forms.ActiveWindowSelector();
            if( selector.ShowDialog() == DialogResult.OK )
            {
                ((Config.Window)windowConfigListBox.SelectedItem).UpdateFrom(selector.Window);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // TODO: Add warning/confirmation in the case that window is referenced in a
            //       locatedwindow
            m_config.WindowConfigurations.Remove((Config.Window)windowConfigListBox.SelectedItem);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Config.Window newConfig = new Config.Window();
            newConfig.m_windowTitle = "New";
            m_config.WindowConfigurations.Add(newConfig);
            windowConfigListBox.SelectedItem = newConfig;
        }

        private void activeWindowsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SetConfigurationEditEnabled(windowConfigListBox.SelectedItem != null);
        }
    }
}
