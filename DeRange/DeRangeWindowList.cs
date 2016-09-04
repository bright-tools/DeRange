using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32Interop.WinHandles;

namespace DeRange
{
    public partial class DeRangeWindowList : Form
    {

        private IEnumerable<WindowHandle> currentWindows = null;
        public  DeRangeConfiguration      m_config;

        public DeRangeWindowList(DeRangeConfiguration p_config)
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

        private void updateActiveWindowsList_Click(object sender, EventArgs e)
        {
            captureButton.Enabled = false;
            activeWindowsListBox.Items.Clear();

            currentWindows = TopLevelWindowUtils.FindWindows(w => (w.IsVisible() == true) && (w.GetWindowText() != ""));

            activeWindowsListBox.BeginUpdate();

            foreach (WindowHandle windowHandle in currentWindows)
            {
                activeWindowsListBox.Items.Insert(activeWindowsListBox.Items.Count, windowHandle.GetWindowText());
            }

            activeWindowsListBox.EndUpdate();
        }

        private void activeWindowsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            captureButton.Enabled = true;
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            DeRangeWindowConfiguration windowConfig = new DeRangeWindowConfiguration(currentWindows.ElementAt(activeWindowsListBox.SelectedIndex));
            DeRangeWindowEdit winEdit = new DeRangeWindowEdit(windowConfig);

            if( winEdit.ShowDialog() == DialogResult.OK )
            {
                m_config.windowConfigurations.Add(windowConfig);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            m_config.windowConfigurations.Remove((DeRangeWindowConfiguration)windowConfigListBox.SelectedItem);
        }
    }
}
