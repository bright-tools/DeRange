using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win32Interop.WinHandles;

namespace DeRange.Forms
{
    public partial class ActiveWindowSelector : ParentForm
    {
        private List<WindowHandle> m_currentWindows = null;

        public WindowHandle Window { get; set; }

        protected override System.Drawing.Size WindowSettingSize {
            get
            {
                return Properties.Settings.Default.ActiveWindowSelectorSize;
            }
            set
            {
                Properties.Settings.Default.ActiveWindowSelectorSize = value;
            }
        }

        protected override System.Windows.Forms.FormWindowState WindowSettingState {
            get
            {
                return Properties.Settings.Default.ActiveWindowSelectorState;
            }
            set
            {
                Properties.Settings.Default.ActiveWindowSelectorState = value;
            }
        }

        protected override System.Drawing.Point WindowSettingLocation {
            get
            {
                return Properties.Settings.Default.ActiveWindowSelectorLocation;
            }
            set
            {
                Properties.Settings.Default.ActiveWindowSelectorLocation = value;
            }
        }

        public ActiveWindowSelector()
        {
            InitializeComponent();

            PopulateWindowList();

            okButton.Enabled = false;
        }

        private void PopulateWindowList()
        {
            activeWindowsListBox.Items.Clear();

            IEnumerable<WindowHandle> currentWindows = WindowModifier.GetAllVisibleWindows();

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
    }
}
