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
    public partial class Options : ParentForm
    {
        protected override System.Drawing.Size WindowSettingSize
        {
            get
            {
                return Properties.Settings.Default.OptionsEditSize;
            }
            set
            {
                Properties.Settings.Default.OptionsEditSize = value;
            }
        }

        protected override System.Windows.Forms.FormWindowState WindowSettingState
        {
            get
            {
                return Properties.Settings.Default.OptionsEditState;
            }
            set
            {
                Properties.Settings.Default.OptionsEditState = value;
            }
        }

        protected override System.Drawing.Point WindowSettingLocation
        {
            get
            {
                return Properties.Settings.Default.OptionsEditLocation;
            }
            set
            {
                Properties.Settings.Default.OptionsEditLocation = value;
            }
        }

        public Options()
        {
            InitializeComponent();
        }

    }
}
