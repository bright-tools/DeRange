using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Win32;

namespace DeRange
{
    public class DeRangeApp : ApplicationContext, UserNotifier
    {
        Forms.DeRange configWindow;
        Forms.Options optionsWindow;
        NotifyIcon notifyIcon;
        Config.Top config;

        public DeRangeApp()
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            setupNotifyIcon();
            loadConfig();

            checkOptions();

            configWindow = new Forms.DeRange(config, this);
        }

        const String configFile = "derange_config.xml";

        private void checkOptions()
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            
            if ( Properties.Settings.Default.RunAtStartup )
            {
                rkApp.SetValue("DeRange", Application.ExecutablePath);
            }
            else
            {
                rkApp.DeleteValue("DeRange", false);
            }
        }

        public void Notify(String title, String notification)
        {
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = notification;
            notifyIcon.ShowBalloonTip(20000);
        }

        void setupNotifyIcon()
        {
            // TODO: Add ability to choose an arrangement to apply from the menu
            
            // TODO: Add import/export function from menu

            // TODO: Add keyboard shortcuts to menu.

            MenuItem configMenuItem = new MenuItem("Configuration", new EventHandler(ShowConfig));
            MenuItem optionsMenuItem = new MenuItem("Options", new EventHandler(ShowOptions));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = Properties.Resources.tray_icon;
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, optionsMenuItem, exitMenuItem });
            notifyIcon.Visible = true;
        }

        void loadConfig()
        {
            config = new Config.Top();
            XmlSerializer serializer;
            try
            {
                serializer = new XmlSerializer(typeof(Config.Top));
            } 
            catch( Exception e)
            {
                serializer = null;
            }
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

            try
            {
                if (isoStore.FileExists(configFile))
                {
                    IsolatedStorageFileStream fs = new IsolatedStorageFileStream(configFile, FileMode.Open, isoStore);
                    config = (Config.Top)serializer.Deserialize(fs);
                    fs.Close();
                }
                else
                {
                    // TODO
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void writeConfig()
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            XmlSerializer serializer = new XmlSerializer(typeof(Config.Top));

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(configFile, FileMode.Create, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    serializer.Serialize(writer, config);
                }
            }
        }

        void ShowOptions(object sender, EventArgs e)
        {
            // If we are already showing the window, merely focus it.
            if (optionsWindow == null)
            {
                optionsWindow = new Forms.Options();
                optionsWindow.FormClosed += optionsFormClosed;
                optionsWindow.Show();
            }
            else
            {
                optionsWindow.Activate();
            }
        }

        void optionsFormClosed(object sender, EventArgs e)
        {
            optionsWindow = null;
            checkOptions();
        }

        void ShowConfig(object sender, EventArgs e)
        {
            // If we are already showing the window, merely focus it.
            if (configWindow.Visible)
            {
                configWindow.Activate();
            }
            else
            {
                configWindow.ShowDialog();
            }
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            writeConfig();
            Properties.Settings.Default.Save();

            //Cleanup so that the icon will be removed when the application is closed
            notifyIcon.Visible = false;
        }
    }
}
