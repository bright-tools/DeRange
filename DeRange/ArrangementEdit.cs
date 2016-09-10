using DeRange.Config;
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

            if (m_config.Arrangements.Count > 0)
            {
                arrangementListBox.SelectedItem = m_config.Arrangements[0];
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
        }

        void windowConfigurationListChanged(object sender, ListChangedEventArgs e)
        {

        }
    }
}
