using DeRange.Config;
using DeRange.Forms;
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
    public partial class ArrangementEdit : ParentForm
    {
        Top m_config;

        private Config.Arrangement SelectedArrangement {
            get 
            {
                return (Arrangement)(arrangementListBox.SelectedItem);
            }
        }

        private Config.LocatedWindow SelectedLocatedWindow
        {
            get
            {
                return (LocatedWindow)(locatedWindowListbox.SelectedItem);
            }
        }

        protected override System.Drawing.Size WindowSettingSize
        {
            get
            {
                return Properties.Settings.Default.ArrangementEditSize;
            }
            set
            {
                Properties.Settings.Default.ArrangementEditSize = value;
            }
        }

        protected override System.Windows.Forms.FormWindowState WindowSettingState
        {
            get
            {
                return Properties.Settings.Default.ArrangementEditState;
            }
            set
            {
                Properties.Settings.Default.ArrangementEditState = value;
            }
        }

        protected override System.Drawing.Point WindowSettingLocation
        {
            get
            {
                return Properties.Settings.Default.ArrangementEditLocation;
            }
            set
            {
                Properties.Settings.Default.ArrangementEditLocation = value;
            }
        }

        public ArrangementEdit(Top p_config)
        {
            m_config = p_config;

            InitializeComponent();

            deRangeArrangementListBindingSource.DataSource = m_config.Arrangements;
            this.nonMatchingWindowsComboBox.DataSource = System.Enum.GetValues(typeof(Arrangement.NonMatchingStatus));

            if (m_config.Arrangements.Count > 0)
            {
                arrangementListBox.SelectedItem = m_config.Arrangements[0];

                hotKeySelector1.DataSource = m_config.Arrangements[0].Shortcut;
                locatedWindowBindingSource.DataSource = m_config.Arrangements[0].WindowPositions;
            }
            else
            {
                hotKeySelector1.DataSource = new KeyboardShortcut();
            }

            m_config.Arrangements.ListChanged += windowConfigurationListChanged;

            SetArrangementEditEnabled();
        }

        private void addArrangementButton_Click(object sender, EventArgs e)
        {
            Arrangement newArrangement = new Arrangement();
            m_config.Arrangements.Add( newArrangement );
            arrangementListBox.SelectedItem = newArrangement;
        }

        private void removeArrangementButton_Click(object sender, EventArgs e)
        {
            m_config.Arrangements.Remove(SelectedArrangement);
        }

        private void SetArrangementEditEnabled()
        {
            bool enabled = m_config.Arrangements.Count > 0;

            hotKeySelector1.Enabled = enabled;
            nameTextBox.Enabled = enabled;
            addButton.Enabled = enabled;
            arrangementListBox.Enabled = enabled;
            nonMatchingWindowsComboBox.Enabled = enabled;
            setZIndexCheckBox.Enabled = enabled;

            SetLocatedWindowButtons();
        }

        private void SetLocatedWindowButtons()
        {
            bool enabled = (m_config.Arrangements.Count > 0) && (SelectedArrangement!= null) && (SelectedLocatedWindow != null);
            upButton.Enabled = enabled && (SelectedLocatedWindow != SelectedArrangement.WindowPositions.FirstOrDefault());
            downButton.Enabled = enabled && (SelectedLocatedWindow != SelectedArrangement.WindowPositions.LastOrDefault());
        }

        void windowConfigurationListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void updateLocatedWindowButtons()
        {
            bool enabled = (locatedWindowListbox.SelectedItem != null);

            removeButton.Enabled = enabled;
            updateButton.Enabled = enabled;
            testButton.Enabled = enabled;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WindowLocationSelector winSelect = new WindowLocationSelector( m_config );
            if( winSelect.ShowDialog() == DialogResult.OK )
            {
                LocatedWindow locWin = new LocatedWindow();

                locWin.LocationGUID = winSelect.SelectedLocation.GUID;
                locWin.WindowGUID = winSelect.SelectedWindow.GUID;

                SelectedArrangement.WindowPositions.Add(locWin);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            SelectedArrangement.WindowPositions.Remove(SelectedLocatedWindow);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            WindowLocationSelector winSelect = new WindowLocationSelector(m_config, SelectedLocatedWindow.WindowGUID, 
                                                                          SelectedLocatedWindow.LocationGUID,
                                                                          SelectedLocatedWindow.AllowMultipleMatches);
            if (winSelect.ShowDialog() == DialogResult.OK)
            {
                SelectedLocatedWindow.LocationGUID = winSelect.SelectedLocation.GUID;
                SelectedLocatedWindow.WindowGUID = winSelect.SelectedWindow.GUID;
                SelectedLocatedWindow.AllowMultipleMatches = winSelect.AllowMultipleMatches;
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            WindowModifier.ApplyArrangement(m_config, SelectedArrangement);
        }

        private void arrangementListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SetArrangementEditEnabled();
            if (SelectedArrangement != null)
            {
                hotKeySelector1.DataSource = SelectedArrangement.Shortcut;
                locatedWindowBindingSource.DataSource = SelectedArrangement.WindowPositions;
            }
            else
            {
                hotKeySelector1.DataSource = new KeyboardShortcut();
                locatedWindowBindingSource.DataSource = new BindingList<LocatedWindow>();
            }
        }

        private void locatedWindowListbox_SelectedValueChanged(object sender, EventArgs e)
        {
            updateLocatedWindowButtons();

            SetLocatedWindowButtons();
        }

        private void swapLocatedWindows( int p_first, int p_second )
        {
            BindingListUtils.Swap(SelectedArrangement.WindowPositions, p_first, p_second);
            locatedWindowListbox.SelectedIndex = p_second;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int selected = locatedWindowListbox.SelectedIndex;

            swapLocatedWindows(selected, selected - 1);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            int selected = locatedWindowListbox.SelectedIndex;

            swapLocatedWindows(selected, selected + 1);
        }
    }
}
