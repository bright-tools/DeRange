using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeRange.Forms
{
    public partial class HotKeySelector : UserControl
    {
        public HotKeySelector()
        {
            InitializeComponent();
            this.keyCombobox.DataSource = System.Enum.GetValues(typeof(System.Windows.Forms.Keys));
            this.keyboardShortCutBindingSource.DataSource = new Config.KeyboardShortcut();
        }

        public Config.KeyboardShortcut DataSource
        {
            set
            {
                this.keyboardShortCutBindingSource.DataSource = value;
            }
        }
    }
}
