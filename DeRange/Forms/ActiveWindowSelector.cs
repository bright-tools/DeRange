using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Win32Interop.WinHandles;

namespace DeRange
{
    public partial class ActiveWindowSelector : Form
    {
        private List<WindowHandle> m_currentWindows = null;

        public WindowHandle Window { get; set; }

        public ActiveWindowSelector()
        {
            InitializeComponent();

            PopulateWindowList();

            okButton.Enabled = false;
        }

        private void PopulateWindowList()
        {
            activeWindowsListBox.Items.Clear();

            IEnumerable<WindowHandle> currentWindows = TopLevelWindowUtils.FindWindows(w => (w.IsVisible() == true) && (w.GetWindowText() != ""));

            activeWindowsListBox.BeginUpdate();

            m_currentWindows = new List<WindowHandle>();

            foreach (WindowHandle windowHandle in currentWindows)
            {
                activeWindowsListBox.Items.Insert(activeWindowsListBox.Items.Count, windowHandle.GetWindowText());
                m_currentWindows.Add(windowHandle);
            }

            activeWindowsListBox.EndUpdate();
        }

        private void activeWindowsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
            Window = m_currentWindows[activeWindowsListBox.SelectedIndex];
        }

        private void activeWindowsListBox_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ActiveWindowSelector_Load(object sender, EventArgs e)
        {
            if ((Properties.Settings.Default.ActiveWindowSelectorSize.Width != 0 ) && (Properties.Settings.Default.ActiveWindowSelectorSize.Height != 0))
            {
                this.WindowState = Properties.Settings.Default.ActiveWindowSelectorState;

                // we don't want a minimized window at startup
                if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

                this.Location = Properties.Settings.Default.ActiveWindowSelectorLocation;
                this.Size = Properties.Settings.Default.ActiveWindowSelectorSize;
            }
        }

        private void ActiveWindowSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ActiveWindowSelectorState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.ActiveWindowSelectorLocation = this.Location;
                Properties.Settings.Default.ActiveWindowSelectorSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.ActiveWindowSelectorLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.ActiveWindowSelectorSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }
    }
}
