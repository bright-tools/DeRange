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

namespace DeRange.Forms
{
    public partial class LocationEdit : ParentForm
    {
        private Config.Top m_config;

        protected override System.Drawing.Size WindowSettingSize
        {
            get
            {
                return Properties.Settings.Default.LocationEditSize;
            }
            set
            {
                Properties.Settings.Default.LocationEditSize = value;
            }
        }

        protected override System.Windows.Forms.FormWindowState WindowSettingState
        {
            get
            {
                return Properties.Settings.Default.LocationEditState;
            }
            set
            {
                Properties.Settings.Default.LocationEditState = value;
            }
        }

        protected override System.Drawing.Point WindowSettingLocation
        {
            get
            {
                return Properties.Settings.Default.LocationEditLocation;
            }
            set
            {
                Properties.Settings.Default.LocationEditLocation = value;
            }
        }

        public LocationEdit(Config.Top p_config)
        {
            m_config = p_config;
            InitializeComponent();
            populateMonitorCombobox();

            this.statusComboBox.DataSource = System.Enum.GetValues(typeof(Config.Location.WindowStatus));
            this.deRangeWindowPositionListBindingSource.DataSource = m_config.WindowPositions;

            if (m_config.WindowPositions.Count > 0)
            {
                positionList.SelectedItem = m_config.WindowPositions[0];
            }

            updateButtons();
        }

        private void populateMonitorCombobox()
        {
            BindingList < KeyValuePair < int, string>> screenList = new BindingList<KeyValuePair<int, string>>();
            for ( int i = 0; i < Screen.AllScreens.Count(); i++ )
            {
                screenList.Add( new KeyValuePair< int, string>(i, "on window "+i.ToString() ));
            }
            monitorCombobox.DataSource = screenList;
        }

        private void updateButtons()
        {
            bool itemsInList = (positionList.Items.Count > 0);
            bool itemSelected = (positionList.SelectedItem != null);

            removePositionButton.Enabled = itemsInList;

            testButton.Enabled = itemSelected;
            updateFromWindowButton.Enabled = itemSelected;
            nameTextBox.Enabled = itemSelected;
            xPosTextbox.Enabled = itemSelected;
            yPosTextbox.Enabled = itemSelected;
            xyPosEnabledCheckBox.Enabled = itemSelected;
            widthTextbox.Enabled = itemSelected;
            heightTextbox.Enabled = itemSelected;
            statusComboBox.Enabled = itemSelected;
            sizeEnabledCheckbox.Enabled = itemSelected;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = xyPosEnabledCheckBox.Checked;

            xPosTextbox.Enabled = enabled;
            yPosTextbox.Enabled = enabled;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Forms.ActiveWindowSelector winList = new Forms.ActiveWindowSelector();

            if (winList.ShowDialog() == DialogResult.OK)
            {
                Config.Window win= new Config.Window( winList.Window );
                Config.Location pos = (Config.Location)positionList.SelectedItem;

                WindowModifier.ApplyModification(win, pos);
            }
        }

        private void addPositionButton_Click_1(object sender, EventArgs e)
        {
            Config.Location newPosn = new Config.Location();
            m_config.WindowPositions.Add(newPosn);
            positionList.SelectedItem = newPosn;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // TODO: Add warning/confirmation in the case that location is referenced in a
            //       locatedwindow

            if (positionList.SelectedItem!= null)
            {
                m_config.WindowPositions.Remove((Config.Location)positionList.SelectedItem);
            }
        }

        private void updateFromWindowButton_Click(object sender, EventArgs e)
        {
            Forms.ActiveWindowSelector winList = new Forms.ActiveWindowSelector();

            if (winList.ShowDialog() == DialogResult.OK)
            {
                ((Config.Location)positionList.SelectedItem).UpdateFrom(winList.Window);
            }
        }

        private void positionList_SelectedValueChanged(object sender, EventArgs e)
        {
            updateButtons();
        }

        private void statusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            monitorCombobox.Enabled = ((Config.Location.WindowStatus)statusComboBox.SelectedValue) == Config.Location.WindowStatus.Maximised;
        }
    }
}
