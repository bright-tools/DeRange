using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Win32;
using System.Security.Policy;

namespace DeRange
{
    public class DeRangeApp : ApplicationContext, UserNotifier
    {
        Forms.DeRange configWindow;
        Forms.Options optionsWindow;
        NotifyIcon notifyIcon;
        Config.Top config;
        ToolStripMenuItem arrangementMenuItem;

        public DeRangeApp()
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            setupNotifyIcon();
            loadConfigFromIsolatedStorage();

            checkOptions();

            configWindow = new Forms.DeRange(config, this);
        }

        const String configFile = "derange_config.xml";

        #region Notify Menu & Event Handlers

        public void Notify(String title, String notification)
        {
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = notification;
            notifyIcon.ShowBalloonTip(20000);
        }

        void setupNotifyIcon()
        {
            // TODO: Add keyboard shortcuts to menu.

            ToolStripMenuItem aboutMenuItem = new ToolStripMenuItem("About", null, new EventHandler(ShowAbout));
            ToolStripMenuItem configMenuItem = new ToolStripMenuItem("Configuration");
            ToolStripMenuItem optionsMenuItem = new ToolStripMenuItem("Options", null, new EventHandler(ShowOptions));

            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Edit", null, new EventHandler(ShowConfig));
            ToolStripMenuItem exportMenuItem = new ToolStripMenuItem("Export", null, new EventHandler(ExportConfig));
            ToolStripMenuItem importMenuItem = new ToolStripMenuItem("Import");
            configMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] { editMenuItem, exportMenuItem, importMenuItem });

            ToolStripMenuItem importReplaceMenuItem = new ToolStripMenuItem("Replace", null, new EventHandler(ImportReplace));
            ToolStripMenuItem importMergeMenuItem = new ToolStripMenuItem("Merge", null, new EventHandler(ImportMerge));
            importMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] { importReplaceMenuItem, importMergeMenuItem });

            arrangementMenuItem = new ToolStripMenuItem("Apply Arrangement");

            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit", null, new EventHandler(Exit));

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = Properties.Resources.tray_icon;
            notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.AddRange(new ToolStripMenuItem[] { aboutMenuItem, configMenuItem, optionsMenuItem, arrangementMenuItem, exitMenuItem });
            // We'll dynamically generate this menu based on the configuration
            notifyIcon.ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(NotifyMenu_Opening);
            notifyIcon.Visible = true;
        }

        void ApplyArrangement(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

                if (menuItem.Tag is Config.Arrangement)
                {
                    Config.Arrangement arrangement = (Config.Arrangement)menuItem.Tag;

                    WindowModifier.ApplyArrangement(config, arrangement);
                }
            }
        }

        void NotifyMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            arrangementMenuItem.DropDownItems.Clear();

            foreach( Config.Arrangement arrangement in config.Arrangements )
            {            
                ToolStripMenuItem arrangementItem = new ToolStripMenuItem(arrangement.Name, null, new EventHandler(ApplyArrangement));
                arrangementItem.Tag = arrangement;
                arrangementMenuItem.DropDownItems.Add(arrangementItem);
            }

            e.Cancel = false;
        }

        void ImportMerge(object sender, EventArgs e)
        {
            Import(false);
        }

        void ImportReplace(object sender, EventArgs e)
        {
            Import(true,true);
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

        void ShowAbout(object sender, EventArgs e)
        {
            Forms.About aboutForm = new Forms.About();
            aboutForm.ShowDialog();
        }

        #endregion

        #region Config Handling

        Stream GetImportFile()
        {
            Stream retVal = null;
            System.Windows.Forms.OpenFileDialog saveFileDlg = new System.Windows.Forms.OpenFileDialog();

            saveFileDlg.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDlg.FilterIndex = 1;
            saveFileDlg.RestoreDirectory = true;
            
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = null;
                try
                {
                    if ((myStream = saveFileDlg.OpenFile()) != null)
                    {
                        retVal = myStream;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            return retVal;
        }

        void Import(bool replace, bool p_warn = false)
        {
            Stream importStream = GetImportFile();
            bool cont = true;

            if (importStream != null)
            {
                if (replace & p_warn)
                {
                    cont = MessageBox.Show("Current configuration will be cleared & replaced.  OK to continue with import?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes;
                }

                if (cont)
                {
                    configWindow.CleanUp();
                    loadConfig(importStream, replace);
                    configWindow = new Forms.DeRange(config, this);
                }
            }
        }

        void ExportConfig(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFileDlg = new System.Windows.Forms.SaveFileDialog();

            saveFileDlg.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDlg.FilterIndex = 1;
            saveFileDlg.RestoreDirectory = true;
            saveFileDlg.OverwritePrompt = true;

            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = null;
                try
                {
                    if ((myStream = saveFileDlg.OpenFile()) != null)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Config.Top));
                        serializer.Serialize(myStream, config);
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not write file to disk. Original error: " + ex.Message);
                }
            }
        }

        void loadConfigFromIsolatedStorage()
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

            try
            {
                if (isoStore.FileExists(configFile))
                {
                    IsolatedStorageFileStream fs = new IsolatedStorageFileStream(configFile, FileMode.Open, isoStore);
                    loadConfig(fs,true);
                }
                else
                {
                    config = new Config.Top();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void loadConfig(Stream fs, bool replace = true)
        {
            XmlSerializer serializer;
            try
            {
                serializer = new XmlSerializer(typeof(Config.Top));
            } 
            catch( Exception e)
            {
                serializer = null;
            }

            config = (Config.Top)serializer.Deserialize(fs);
            fs.Close();
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

        #endregion

        #region Options Handling 

        private void checkOptions()
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (Properties.Settings.Default.RunAtStartup)
            {
                rkApp.SetValue("DeRange", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {
                rkApp.DeleteValue("DeRange", false);
            }
        }

        void optionsFormClosed(object sender, EventArgs e)
        {
            optionsWindow = null;
            checkOptions();
        }

        #endregion

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
