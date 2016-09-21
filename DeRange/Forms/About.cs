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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            versionLabel.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            apacheLicense.Rtf = global::DeRange.Properties.Resources.LICENSE;
        }
    }
}
