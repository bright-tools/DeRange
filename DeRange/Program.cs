using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace DeRange
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{"+ Assembly.GetExecutingAssembly().GetType().GUID.ToString() + "}");

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
