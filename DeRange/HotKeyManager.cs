using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;

namespace DeRange
{
    /* This solution re-worked from 
       http://stackoverflow.com/questions/48935/how-can-i-register-a-global-hot-key-to-say-ctrlshiftletter-using-wpf-and-ne
       using information from 
       http://www.thomaslevesque.com/2014/02/05/wpf-declare-global-hotkeys-in-xaml-with-nhotkey/
       
       Using ComponentDispatcher.ThreadFilterMessage (as in the StackOverflow reference) doesn't work 
       for WPF */

    public class HotKeyManager : IDisposable
    {

        public class HotKey
        {
            public Keys Key { get; private set; }
            public KeyModifier KeyModifiers { get; private set; }
            public Action<HotKey> Action { get; private set; }
            public int Id {  get { return (int)Key + ((int)KeyModifiers * 0x10000);  } }

            public HotKey(System.Windows.Forms.Keys k, KeyModifier keyModifiers, Action<HotKey> action)
            {
                Key = k;
                KeyModifiers = keyModifiers;
                Action = action;
            }
        };

        private Dictionary<int, HotKey> m_hotKeys = new Dictionary<int, HotKey>();

        public const int WmHotKey = 0x0312;

        private bool m_disposed = false;

        private  readonly HwndSource m_hwndSurrogate;
        internal static readonly IntPtr m_hwndMessage = (IntPtr)(-3);

        public HotKeyManager()
        {
            var parameters = new HwndSourceParameters("HotkeyHwndSurrogate")
            {
                HwndSourceHook = HandleMessage,
                ParentWindow =   m_hwndMessage
            };
            m_hwndSurrogate = new HwndSource(parameters);
        }

        public bool Register(Keys k, KeyModifier keyModifiers, Action<HotKey> action)
        {
            HotKey newKey = new HotKey(k, keyModifiers, action);
            m_hotKeys.Add(newKey.Id, newKey);
            bool retVal = true;

            if( ! RegisterHotKey(m_hwndSurrogate.Handle, newKey.Id, (UInt32)newKey.KeyModifiers, (UInt32)newKey.Key) )
            {
                retVal = false;
                m_hotKeys.Remove(newKey.Id);
            }

            return retVal;
        }

        // ******************************************************************
        public void UnregisterAll()
        {
            foreach( int id in m_hotKeys.Keys )
            {
                UnregisterHotKey(m_hwndSurrogate.Handle, id);
            }
            m_hotKeys.Clear();
        }

        // ******************************************************************
        private IntPtr HandleMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam, ref bool handled)
        {
            if (!handled)
            {
                if (msg == WmHotKey)
                {
                    HotKey hotKey;

                    if (m_hotKeys.TryGetValue((int)wparam, out hotKey))
                    {
                        if (hotKey.Action != null)
                        {
                            hotKey.Action.Invoke(hotKey);
                        }
                        handled = true;
                    }
                }
            }
            return IntPtr.Zero;
        }

        // ******************************************************************
        // Implement IDisposable.
        // Do not make this method virtual.
        // A derived class should not be able to override this method.
        public void Dispose()
        {
            Dispose(true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        // ******************************************************************
        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be _disposed.
        // If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be _disposed.
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.m_disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    // Dispose managed resources.
                    UnregisterAll();
                }

                // Note disposing has been done.
                m_disposed = true;
            }
        }

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, UInt32 fsModifiers, UInt32 vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }

    // ******************************************************************
    [Flags]
    public enum KeyModifier
    {
        None = 0x0000,
        Alt = 0x0001,
        Ctrl = 0x0002,
        NoRepeat = 0x4000,
        Shift = 0x0004,
        Win = 0x0008
    }

    // ******************************************************************
}