using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            this.windowConfigurationsBindingSource.DataSource = m_config;

            m_config.windowConfigurations.ListChanged += windowConfigurationListChanged;

            updateButtonStatuses();
        }

        private void updateButtonStatuses()
        {
            removeButton.Enabled = (m_config.windowConfigurations.Count > 0);
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
            m_config.windowConfigurations.Remove((Config.Window)windowConfigListBox.SelectedItem);
            activeWindowsListBox_SelectedIndexChanged(sender, e);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Config.Window newConfig = new Config.Window();
            m_config.windowConfigurations.Add(newConfig);
            newConfig.m_windowTitle = "New";
            deRangeWindowConfigurationBindingSource.DataSource = (Config.Window)windowConfigListBox.SelectedItem;
        }
    }
}
