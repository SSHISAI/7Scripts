using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace _7Scripts
{
    class Keyboard
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(byte bVk, int bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern ushort GetAsyncKeyState(int vKey);

        public static bool IsKeyDown(Keys key)
        {
            return 0 != (GetAsyncKeyState((int)key) & 0x8000);
        }
    }
}
