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
    }
}
