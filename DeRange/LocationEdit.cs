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
    public partial class LocationEdit : Form
    {
        private Config.Top m_config;
        public LocationEdit(Config.Top p_config)
        {
            m_config = p_config;
            InitializeComponent();

            this.statusComboBox.DataSource = System.Enum.GetValues(typeof(Config.Location.WindowStatus));
            this.deRangeWindowPositionListBindingSource.DataSource = m_config.WindowPositions;

            if (m_config.WindowPositions.Count > 0)
            {
                positionList.SelectedItem = m_config.WindowPositions[0];
            }
            else
            {
                // Give the controls something to bind to.  In the case that there no items in the
                //  window configuration list, this prevents an error where attempt is made to bind
                //  to a property of NULL 
                this.deRangeWindowPositionBindingSource.DataSource = new Config.Window();
            }

            updateButtons();
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posnIdx = positionList.SelectedIndex;
            if (posnIdx >= 0)
            {
                this.deRangeWindowPositionBindingSource.DataSource = m_config.WindowPositions.ElementAt(posnIdx);
            }
            updateButtons();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = xyPosEnabledCheckBox.Checked;

            xPosTextbox.Enabled = enabled;
            yPosTextbox.Enabled = enabled;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ActiveWindowSelector winList = new ActiveWindowSelector();

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
            updateButtons();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(positionList.SelectedItem!= null)
            {
                m_config.WindowPositions.Remove((Config.Location)positionList.SelectedItem);
            }
            updateButtons();
        }

        private void updateFromWindowButton_Click(object sender, EventArgs e)
        {
            ActiveWindowSelector winList = new ActiveWindowSelector();

            if (winList.ShowDialog() == DialogResult.OK)
            {
                ((Config.Location)positionList.SelectedItem).UpdateFrom(winList.Window);
            }
        }
    }
}
