using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace DeRange
{
    static class Program
    {
        static GuidAttribute guidAttr = (GuidAttribute)typeof(Program).Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
        static String mutexName = "{" + guidAttr.Value + "}";
        static Mutex mutex = new Mutex(true, mutexName);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new DeRangeApp());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("DeRange is already running.");
            }
        }
    }
}
