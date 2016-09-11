using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeRange.Forms
{
    public partial class WindowLocationSelector : Form
    {
        private Config.Top m_config;

        public Config.Window SelectedWindow
        {
            get; set;
        } = null;
        public Config.Location SelectedLocation
        {
            get; set;
        } = null;

        public WindowLocationSelector( Config.Top p_config )
        {
            m_config = p_config;

            InitializeComponent();

            this.windowListBindingSource.DataSource = p_config.WindowConfigurations;
            this.locationListBindingSource.DataSource = p_config.WindowPositions;

            okButton.Enabled = false;
        }

        private void updateButtons()
        {
            okButton.Enabled = ((windowListbox.SelectedItem != null) &&
                                (locationListbox.SelectedItem != null));
        }

        private void windowListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateButtons();
            SelectedWindow = (Config.Window)(windowListbox.SelectedItem);
        }

        private void locationListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateButtons();
            SelectedLocation = (Config.Location)(locationListbox.SelectedItem);
        }
    }
}
