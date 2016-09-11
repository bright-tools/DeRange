using System;

namespace DeRange.Forms
{
    public partial class DeRange : ParentForm
    {
        private Config.Top m_config;

        protected override System.Drawing.Size WindowSettingSize
        {
            get
            {
                return Properties.Settings.Default.DeRangeMainSize;
            }
            set
            {
                Properties.Settings.Default.DeRangeMainSize = value;
            }
        }

        protected override System.Windows.Forms.FormWindowState WindowSettingState
        {
            get
            {
                return Properties.Settings.Default.DeRangeMainState;
            }
            set
            {
                Properties.Settings.Default.DeRangeMainState = value;
            }
        }

        protected override System.Drawing.Point WindowSettingLocation
        {
            get
            {
                return Properties.Settings.Default.DeRangeMainLocation;
            }
            set
            {
                Properties.Settings.Default.DeRangeMainLocation = value;
            }
        }

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

        private void showWindowCollectionButton_Click(object sender, EventArgs e)
        {
            ArrangementEdit winArr = new ArrangementEdit(m_config);
            winArr.Show();
        }
    }
}
