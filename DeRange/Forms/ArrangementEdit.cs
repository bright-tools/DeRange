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
    public partial class ArrangementEdit : Form
    {
        Top m_config;

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

            m_config.Arrangements.ListChanged += windowConfigurationListChanged;
        }

        private void addArrangementButton_Click(object sender, EventArgs e)
        {
            m_config.Arrangements.Add(new Arrangement());
        }

        private void removeArrangementButton_Click(object sender, EventArgs e)
        {
            m_config.Arrangements.Remove((Arrangement)(arrangementListBox.SelectedItem));
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
                keyboardShortCutBindingSource.DataSource = ((Arrangement)arrangementListBox.SelectedItem).Shortcut;
                locatedWindowBindingSource.DataSource = ((Arrangement)arrangementListBox.SelectedItem).WindowPositions;
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

                ((Arrangement)(arrangementListBox.SelectedItem)).WindowPositions.Add(locWin);
                updateLocatedWindowButtons();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ((Arrangement)(arrangementListBox.SelectedItem)).WindowPositions.Remove((LocatedWindow)(locatedWindowListbox.SelectedItem));
            updateLocatedWindowButtons();
        }

        private void locatedWindowListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLocatedWindowButtons();
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
    }
}
