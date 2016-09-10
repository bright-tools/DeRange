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
        private Config.Top m_config;
        public DeRange(Config.Top p_config)
        {
            InitializeComponent();

            m_config = p_config;
        }

        private void showWindowsButton_Click(object sender, EventArgs e)
        {
            WindowEdit winList = new WindowEdit(m_config);
            winList.Show();
        }

        private void showWindowPositionsButton_Click(object sender, EventArgs e)
        {
            LocationEdit winPost = new LocationEdit(m_config);
            winPost.Show();
        }
    }
}
