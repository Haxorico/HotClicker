using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HotClicker
{
    public partial class Form1
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        //[DllImport("user32.dll")]
        //public static extern bool GetCursorPos(out Point lpPoint);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }
        public Form1()
        {
            InitializeComponent();
            
            int id = 0;     // The id of the hotkey. 
            //RegisterHotKey(this.Handle, id, (int)KeyModifier.Shift, Keys.A.GetHashCode());       // Register Shift + A as global hotkey. 

            RegisterHotKey(this.Handle, id, 0, Keys.PageUp.GetHashCode());       // Register Page Up as global hotkey. 
        }

        private void keyClick(string key)
        {
            SendKeys.Send(key);
        }

        private void mouseClick(bool leftClick, int X, int Y)
        {
            Cursor.Position = new Point(X, Y);
            if (leftClick)
            {
                mouse_event(0x02, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                mouse_event(0x04, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            }
            else
            {
                mouse_event(0x08, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                mouse_event(0x10, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.

                startStop();
                //MessageBox.Show("Hotkey has been pressed!");
                // do something
            }
        }
    }
}
