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
    public partial class DeRange : Form
    {
        private DeRangeConfiguration m_config;
        public DeRange(DeRangeConfiguration p_config)
        {
            InitializeComponent();

            m_config = p_config;
        }

        private void showWindowsButton_Click(object sender, EventArgs e)
        {
            DeRangeWindowList winList = new DeRangeWindowList(m_config);
            winList.Show();
        }

    }
}
