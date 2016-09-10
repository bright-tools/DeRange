using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DeRange
{
    public partial class WindowEdit : Form
    {
        public  Config.Top      m_config;

        public WindowEdit(Config.Top p_config)
        {
            m_config = p_config;

            InitializeComponent();

            this.windowConfigurationsBindingSource.DataSource = m_config.WindowConfigurations;

            if(m_config.WindowConfigurations.Count > 0)
            {
                windowConfigListBox.SelectedItem = m_config.WindowConfigurations[0];
            }
            else
            {
                // Give the controls something to bind to.  In the case that there no items in the
                //  window configuration list, this prevents an error where attempt is made to bind
                //  to a property of NULL 
                this.deRangeWindowConfigurationBindingSource.DataSource = new Config.Window();
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
        }

        private void activeWindowsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (windowConfigListBox.SelectedItem != null)
            {
                this.deRangeWindowConfigurationBindingSource.DataSource = (Config.Window)windowConfigListBox.SelectedItem;
                SetConfigurationEditEnabled(true);
            }
            else if( windowConfigListBox.Items.Count == 0 )
            {
                this.deRangeWindowConfigurationBindingSource.Clear();
                SetConfigurationEditEnabled(false);
            }
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            ActiveWindowSelector selector = new ActiveWindowSelector();
            if( selector.ShowDialog() == DialogResult.OK )
            {
                ((Config.Window)windowConfigListBox.SelectedItem).UpdateFrom(selector.Window);
                this.deRangeWindowConfigurationBindingSource.DataSource = (Config.Window)windowConfigListBox.SelectedItem;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            m_config.WindowConfigurations.Remove((Config.Window)windowConfigListBox.SelectedItem);
            activeWindowsListBox_SelectedIndexChanged(sender, e);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Config.Window newConfig = new Config.Window();
            m_config.WindowConfigurations.Add(newConfig);
            newConfig.m_windowTitle = "New";
            deRangeWindowConfigurationBindingSource.DataSource = (Config.Window)windowConfigListBox.SelectedItem;
        }

    }
}
