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
            this.keyCombobox.DataSource = System.Enum.GetValues(typeof(Keys));

            if (m_config.Arrangements.Count > 0)
            {
                arrangementListBox.SelectedItem = m_config.Arrangements[0];

                keyboardShortCutBindingSource.DataSource = m_config.Arrangements[0].Shortcut;
                locatedWindowBindingSource.DataSource = m_config.Arrangements[0].WindowPositions;
            }
            else
            {
                keyboardShortCutBindingSource.DataSource = new KeyboardShortcut();
            }

            m_config.Arrangements.ListChanged += windowConfigurationListChanged;
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

        private void SetArrangementEditEnabled(bool p_enabled)
        {
            nameTextBox.Enabled = p_enabled;
        }

        private void arrangementListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetArrangementEditEnabled(arrangementListBox.SelectedItem != null);

            if( arrangementListBox.SelectedItem != null )
            {
                keyboardShortCutBindingSource.DataSource = SelectedArrangement.Shortcut;
                locatedWindowBindingSource.DataSource = SelectedArrangement.WindowPositions;
            }
        }

        void windowConfigurationListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void updateLocatedWindowButtons()
        {
            bool enabled = (locatedWindowListbox.SelectedItem != null);

            removeButton.Enabled = enabled;
            updateButton.Enabled = enabled;
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
            SelectedArrangement.WindowPositions.Remove((LocatedWindow)(locatedWindowListbox.SelectedItem));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            LocatedWindow locWin = (LocatedWindow)(locatedWindowListbox.SelectedItem);

            WindowLocationSelector winSelect = new WindowLocationSelector(m_config,locWin.WindowGUID,locWin.LocationGUID);
            if (winSelect.ShowDialog() == DialogResult.OK)
            {
                locWin.LocationGUID = winSelect.SelectedLocation.GUID;
                locWin.WindowGUID = winSelect.SelectedWindow.GUID;
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            WindowModifier.ApplyArrangement(m_config, SelectedArrangement);
        }

        private void arrangementListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            updateLocatedWindowButtons();
        }
    }
}
