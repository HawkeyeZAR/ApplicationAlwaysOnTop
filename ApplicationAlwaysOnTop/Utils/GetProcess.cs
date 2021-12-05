using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using ActiveProcessWindowUtils;

namespace ActiveProcessWindowUtils.Utils
{
    class GetProcess
    {
        //  Used to change TopMost Level of selected processes main screen
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd,
        int hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);
        private const int HWND_TOPMOST = -1;
        private const int HWND_NOTOPMOST = -2;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOSIZE = 0x0001;

        //  Used to change the transparency level of the selected processes main screen.
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERED = 0x80000;
        //private const int WS_EX_TRANSPARENT = 0x20;
        [DllImport("user32.dll")]
        private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);
        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;

        public GetProcess()
        {

        }

        public void TopMost(int index)
        {
            Process process = pID[index];
            SetWindowPos(process.MainWindowHandle,
                HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }

        public void NoTopMost(int index)
        {
            Process process = pID[index];
            SetWindowPos(process.MainWindowHandle,
                HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }

        public void Opaque(byte opacityLevel, int index)
        {
            Process process = pID[index];
            //1.GetWindowLong(process.MainWindowHandle, GWL_EXSTYLE);
            //1.SetWindowLong(process.MainWindowHandle, GWL_EXSTYLE, WS_EX_LAYERED | WS_EX_TRANSPARENT);
            SetWindowLong(process.MainWindowHandle, GWL_EXSTYLE, GetWindowLong(process.MainWindowHandle, GWL_EXSTYLE) | WS_EX_LAYERED);
            SetLayeredWindowAttributes(process.MainWindowHandle, 0, opacityLevel, LWA_ALPHA);
        }

        private List<String> processList = new List<String> ();
        private List<Process> pID = new List<Process> ();
        public List<String> LoadProcesses()
        {        
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                //Adding only process which has got Window Title.
                if (process.MainWindowTitle.Length >= 1)
                {
                    string name = $"{ process.ProcessName}";
                    string windowTitle = $"{ process.MainWindowTitle }";
                    //add the processes to the combobox
                    processList.Add(name + "  " + windowTitle);
                    pID.Add(process);
                }
            }
            return processList;
        }
    }  

}
