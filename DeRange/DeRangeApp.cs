using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.IO.IsolatedStorage;

namespace DeRange
{
    public class DeRangeApp : ApplicationContext
    {
        Forms.DeRange configWindow;
        NotifyIcon notifyIcon;
        Config.Top config;

        public DeRangeApp()
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            setupNotifyIcon();
            loadConfig();

            configWindow = new Forms.DeRange(config);
        }

        const String configFile = "derange_config.xml";

        void setupNotifyIcon()
        {
            // TODO: Add ability to choose an arrangement to apply from the menu
            
            // TODO: Add import/export function from menu

            // TODO: Add keyboard shortcuts to menu.

            MenuItem configMenuItem = new MenuItem("Configuration", new EventHandler(ShowConfig));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = Properties.Resources.tray_icon;
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem });
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
            //Cleanup so that the icon will be removed when the application is closed
            notifyIcon.Visible = false;
        }
    }
}
