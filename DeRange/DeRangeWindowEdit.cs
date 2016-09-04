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
    public partial class DeRangeWindowEdit : Form
    {
        private DeRangeWindowConfiguration m_windowConfig;

        public DeRangeWindowEdit(DeRangeWindowConfiguration p_windowConfig)
        {
            InitializeComponent();

            m_windowConfig = p_windowConfig;

            this.deRangeWindowConfigurationBindingSource.Add(p_windowConfig);
        }
    }
}
