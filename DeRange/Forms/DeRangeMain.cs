using System;
using System.Windows.Forms;

namespace DeRange.Forms
{
    public partial class DeRange : ParentForm
    {
        private Config.Top m_config;
        private UserNotifier m_notifier;

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

        HotKeyManager m_hotKeys = new HotKeyManager();

        public DeRange(Config.Top p_config, UserNotifier p_notifier )
        {
            InitializeComponent();

            m_config = p_config;
            m_notifier = p_notifier;

            resetHotKeys();
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

        private void hotkeyCallback(HotKeyManager.HotKey p_hotKey)
        {
            foreach (Config.Arrangement arrangement in m_config.Arrangements)
            {
                if(( p_hotKey.KeyModifiers == arrangement.Shortcut.KeyModifier) &&
                   ( p_hotKey.Key == arrangement.Shortcut.Key ))
                {
                    WindowModifier.ApplyArrangement(m_config, arrangement);
                }
            }
        }

        private void resetHotKeys()
        {
            m_hotKeys.UnregisterAll();
            String failures = "";

            foreach (Config.Arrangement arrangement in m_config.Arrangements)
            {
                if( ! m_hotKeys.Register(arrangement.Shortcut.Key, arrangement.Shortcut.KeyModifier, hotkeyCallback) )
                {
                    if( failures.Length > 0 )
                    {
                        failures += ", ";
                    }
                    failures += arrangement.Name;
                }
            }

            if( failures.Length > 0 )
            {
                m_notifier.Notify("Failed to bind keys", "Couldn't bind keys for arrangement(s): " + failures + ".\nSelected hotkeys likely already registered to a different application");
            }
        }

        private void arrangementEditDone(object sender, FormClosingEventArgs e)
        {
            resetHotKeys();
        }

        private void showWindowCollectionButton_Click(object sender, EventArgs e)
        {
            ArrangementEdit winArr = new ArrangementEdit(m_config);
            winArr.FormClosing += arrangementEditDone;
            winArr.Show();
        }
    }
}
