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
            linkLabel1.Links.Add(0, 7, "https://github.com/bright-tools/DeRange");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void apacheLicense_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText.ToString());
        }
    }
}
