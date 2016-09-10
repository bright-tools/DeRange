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
    public partial class DeRangePositionEdit : Form
    {
        private DeRangeConfiguration m_config;
        public DeRangePositionEdit(DeRangeConfiguration p_config)
        {
            m_config = p_config;
            InitializeComponent();

            this.deRangeWindowPositionListBindingSource.DataSource = m_config.m_windowPositions;

            updateButtons();
        }

        private void updateButtons()
        {
            bool itemsInList = (positionList.Items.Count > 0);
            bool itemSelected = (positionList.SelectedItem != null);

            removePositionButton.Enabled = itemsInList;

            testButton.Enabled = itemSelected;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posnIdx = positionList.SelectedIndex;
            if (posnIdx >= 0)
            {
                this.deRangeWindowPositionBindingSource.DataSource = m_config.m_windowPositions.ElementAt(posnIdx);
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
            DeRangeActiveWindowSelector winList = new DeRangeActiveWindowSelector();

            if (winList.ShowDialog() == DialogResult.OK)
            {
                DeRangeWindowConfiguration win= new DeRangeWindowConfiguration( winList.Window );
                DeRangeWindowPosition pos = (DeRangeWindowPosition)positionList.SelectedItem;

                DeRangeWindowModifier.ApplyModification(win, pos);
            }
        }

        private void addPositionButton_Click_1(object sender, EventArgs e)
        {
            DeRangeWindowPosition newPosn = new DeRangeWindowPosition();
            m_config.m_windowPositions.Add(newPosn);
            updateButtons();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(positionList.SelectedItem!= null)
            {
                m_config.m_windowPositions.Remove((DeRangeWindowPosition)positionList.SelectedItem);
            }
            updateButtons();
        }

        private void updateFromWindowButton_Click(object sender, EventArgs e)
        {
            DeRangeActiveWindowSelector winList = new DeRangeActiveWindowSelector();

            if (winList.ShowDialog() == DialogResult.OK)
            {
                ((DeRangeWindowPosition)positionList.SelectedItem).UpdateFrom(winList.Window);
            }
        }
    }
}
