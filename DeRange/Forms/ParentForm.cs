using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;
using System.Drawing;
using DeRange.Properties;

namespace DeRange.Forms
{
    // This solution taken from http://stackoverflow.com/questions/1620847/how-can-i-get-visual-studio-2008-windows-forms-designer-to-render-a-form-that-im
    //  with thanks to the various contributors

    public class AbstractControlDescriptionProvider<TAbstract, TBase> : TypeDescriptionProvider
    {
        public AbstractControlDescriptionProvider()
            : base(TypeDescriptor.GetProvider(typeof(TAbstract)))
        {
        }

        public override Type GetReflectionType(Type objectType, object instance)
        {
            if (objectType.FullName == typeof(TAbstract).FullName)
                return typeof(TBase);

            return base.GetReflectionType(objectType, instance);
        }

        public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
            if (objectType.FullName == typeof(TAbstract).FullName)
                objectType = typeof(TBase);

            return base.CreateInstance(provider, objectType, argTypes, args);
        }
    }

    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<ParentForm, Form>))]
    public abstract class ParentForm : Form
    {
        protected abstract System.Drawing.Size                  WindowSettingSize { get; set; }
        protected abstract System.Windows.Forms.FormWindowState WindowSettingState { get; set; }
        protected abstract System.Drawing.Point                 WindowSettingLocation { get; set; }

        public ParentForm() : base()
        {
            this.Icon = Resources.tray_icon;
        }

        private bool IsOnScreen( System.Drawing.Point p_point )
        {
            bool retVal = false;
            /* Need to make sure that there's enough window for the user to 'grab', so
             * we use a rect rather than just the top-left point */
            Rectangle rect = new Rectangle(p_point.X, p_point.Y, 20, 20);
            foreach( Screen screen in Screen.AllScreens )
            {
                if( screen.WorkingArea.Contains(rect))
                {
                    retVal = true;
                    break;
                }
            }

            return retVal;
        }

        protected void Form_Load(object sender, EventArgs e)
        {
            if ((WindowSettingSize.Width != 0) && (WindowSettingSize.Height != 0))
            {
                this.WindowState = WindowSettingState;

                /* Check that the top-left point of the position that we're proposing to restore the
                 * window to is on a screen before we do so.  Don't want to restore a window off-screen! */
                if (IsOnScreen(WindowSettingLocation))
                {
                    // we don't want a minimized window at startup
                    if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

                    this.Location = WindowSettingLocation;
                    this.Size = WindowSettingSize;
                }
            }
        }

        protected void Form_Closing(object sender, FormClosingEventArgs e)
        {
            WindowSettingState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                WindowSettingLocation = this.Location;
                WindowSettingSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                WindowSettingLocation = this.RestoreBounds.Location;
                WindowSettingSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }
    }
}
