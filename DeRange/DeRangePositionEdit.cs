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
    public partial class DeRangePositionEdit : Form
    {
        private DeRangeConfiguration m_config;
        public DeRangePositionEdit(DeRangeConfiguration p_config)
        {
            m_config = p_config;
            InitializeComponent();

            this.deRangeWindowConfigurationBindingSource.DataSource = m_config;
        }

        private void window_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = windowList.SelectedIndex;
            if (idx >= 0)
            {
                this.deRangeWindowPositionListBindingSource.DataSource = m_config.windowConfigurations.ElementAt(idx).m_windowPositions;
            }
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            int idx = windowList.SelectedIndex;
            if (idx >= 0)
            {
                DeRangeWindowPosition newPosn = new DeRangeWindowPosition();
                m_config.windowConfigurations.ElementAt(idx).m_windowPositions.Add(newPosn);
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int winIdx = windowList.SelectedIndex;
            int posnIdx = positionList.SelectedIndex;
            if (posnIdx >= 0)
            {
                this.deRangeWindowPositionBindingSource.DataSource = m_config.windowConfigurations.ElementAt(winIdx).m_windowPositions.ElementAt(posnIdx);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = xyPosEnabledCheckBox.Checked;

            xPosTextbox.Enabled = enabled;
            yPosTextbox.Enabled = enabled;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            int winIdx = windowList.SelectedIndex;
            int posnIdx = positionList.SelectedIndex;

            DeRangeWindowConfiguration win = m_config.windowConfigurations.ElementAt(winIdx);
            DeRangeWindowPosition pos = win.m_windowPositions.ElementAt(posnIdx);

            DeRangeWindowModifier.ApplyModification(win, pos);
        }
    }
}
