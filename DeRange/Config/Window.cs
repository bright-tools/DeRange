using System;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Win32Interop.WinHandles;

namespace DeRange.Config
{
    [Serializable]
    [XmlRoot(ElementName = "Window")]
    public class Window : ParentItem
    {
        public Window() : base()
        {

        }

        public Window(WindowHandle p_windowHandle) : base()
        {
            UpdateFrom(p_windowHandle);

            m_matchWindowClass = true;
            m_matchProcessFile = true;
            m_matchProcessName = true;
            m_matchWindowTitle = true;
            WindowTitleIsRegex = false;
            ProcessFileIsRegex = false;
        }

        private string mp_windowName;
        [XmlElement(ElementName = "WindowName")]
        public String WindowName
        {
            get { return mp_windowName; }
            set
            {
                if (mp_windowName != value)
                {
                    mp_windowName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string mp_windowTitle;
        [XmlElement(ElementName = "WindowTitle")]
        public String m_windowTitle {
            get { return mp_windowTitle; }
            set
            {
                if (mp_windowTitle != value)
                {
                    mp_windowTitle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mp_matchWindowTitle;
        [XmlElement(ElementName = "MatchWindowTitle")]
        public bool m_matchWindowTitle
        {
            get { return mp_matchWindowTitle; }
            set
            {
                if( mp_matchWindowTitle != value )
                {
                    mp_matchWindowTitle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mp_regexWindowTitle;
        [XmlElement(ElementName = "WindowTitleAsRegex")]
        public bool WindowTitleIsRegex
        {
            get { return mp_regexWindowTitle; }
            set
            {
                if (mp_regexWindowTitle != value)
                {
                    mp_regexWindowTitle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String mp_processName;
        [XmlElement(ElementName = "ProcessName")]
        public String m_processName {
            get { return mp_processName; }
            set
            {
                if( mp_processName != value )
                {
                    mp_processName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mp_matchProcessName;
        [XmlElement(ElementName = "MatchProcessName")]
        public bool m_matchProcessName
        {
            get { return mp_matchProcessName; }
            set
            {
                if( mp_matchProcessName != value )
                {
                    mp_matchProcessName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String mp_processFile;
        [XmlElement(ElementName = "ProcessFile")]
        public String m_processFile
        {
            get { return mp_processFile; }
            set
            {
                if (mp_processFile != value)
                {
                    mp_processFile = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mp_matchProcessFile;
        [XmlElement(ElementName = "MatchProcessFile")]
        public bool m_matchProcessFile
        {
            get { return mp_matchProcessFile; }
            set
            {
                if (mp_matchProcessFile != value)
                {
                    mp_matchProcessFile = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mp_regexProcessFile;
        [XmlElement(ElementName = "ProcessFileAsRegex")]
        public bool ProcessFileIsRegex
        {
            get { return mp_regexProcessFile; }
            set
            {
                if (mp_regexProcessFile != value)
                {
                    mp_regexProcessFile = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private String mp_windowClass;
        [XmlElement(ElementName = "WindowClass")]
        public String m_windowClass
        {
            get { return mp_windowClass; }
            set
            {
                if (mp_windowClass != value)
                {
                    mp_windowClass = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mp_matchWindowClass;
        [XmlElement(ElementName = "MatchWindowClass")]
        public bool m_matchWindowClass
        {
            get { return mp_matchWindowClass; }
            set
            {
                if (mp_matchWindowClass != value)
                {
                    mp_matchWindowClass = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void UpdateFrom(WindowHandle p_windowHandle)
        {
            m_windowTitle = p_windowHandle.GetWindowText();
            m_windowClass = p_windowHandle.GetClassName();
            m_processFile = p_windowHandle.GetWindowExec();
        }

        public override string ToString()
        {
            string retVal = base.ToString();
            if(( WindowName != null ) && ( WindowName.Length >0 ))
            {
                retVal = WindowName;
            }
            else if(( m_windowTitle!= null ) && ( m_windowTitle.Length > 0))
            {
                retVal = m_windowTitle;
            }
            return retVal;
        }

        public bool IsMatchFor(WindowHandle p_windowHandle)
        {
            bool matched = false;
            bool failed = false;

            if (m_matchWindowClass)
            {
                if (m_windowClass.Equals(p_windowHandle.GetClassName()))
                {
                    matched = true;
                }
                else
                {
                    failed = true;
                }
            }

            if (m_matchProcessFile)
            {
                if (m_processFile.Equals(p_windowHandle.GetWindowExec()))
                {
                    matched = true;
                }
                else
                {
                    failed = true;
                }
            }

            if (m_matchWindowTitle)
            {
                String windowTitle = p_windowHandle.GetWindowText();
                if (WindowTitleIsRegex)
                {
                    Regex winTitleRegex = new Regex(m_windowTitle);
                    if( winTitleRegex.IsMatch(windowTitle))
                    {
                        matched = true;
                    }
                    else
                    {
                        failed = true;
                    }
                }
                else
                {
                    if (m_windowTitle.Equals(windowTitle))
                    {
                        matched = true;
                    }
                    else
                    {
                        failed = true;
                    }
                }
            }

            return matched && !failed;
        }
    }
}
