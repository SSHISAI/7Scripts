using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _7Scripts
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }

        public static void updateName()
        {
            while (true)
            {
                try
                {
                    char[] rndCHAR = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                    string rnd = "";
                    for (int i = 0; i < 10; i++)
                    {
                        Random random = new Random();
                        int index = random.Next(0, rndCHAR.Length);

                        rnd += rndCHAR[index];
                    }
                    Console.Title = rnd;
                    Thread.Sleep(500);
                }
                catch { }
            }
        }

        public static void Start()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("0____________________X");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("Y\n");

            //Starts Controller Thread
            Thread controller_thread = new Thread(Controller);
            controller_thread.SetApartmentState(ApartmentState.STA); //Sets the thread to STA type to fix the DragDrop registration exeption
            controller_thread.IsBackground = true;
            controller_thread.Start();

            //Starts Macro Thread
            Thread macro_thread = new Thread(Macros);
            macro_thread.SetApartmentState(ApartmentState.STA); //Sets the thread to STA type to fix the DragDrop registration exeption
            macro_thread.IsBackground = true;
            macro_thread.Start();
        }

        #region **Anti Recoil**
        static void Controller()
        {
            while (true)
            {
                try
                {
                    //Performance loop
                    while (Dashboard.enabled && Keyboard.IsKeyDown(Keys.LButton) && Keyboard.IsKeyDown(Keys.RButton))
                    {
                        Sleep.PerciseSleep(Dashboard.Delay);
                        while (Dashboard.enabled && Keyboard.IsKeyDown(Keys.LButton) && Keyboard.IsKeyDown(Keys.RButton))
                        {
                            Mouse.RelativeMove(Dashboard.Xpull, Dashboard.Ypull);
                            Sleep.PerciseSleep(Dashboard.Cooldown);
                        }
                    }

                }
                catch { }
            }
        }
        #endregion **Anti Recoil**

        #region **MAcros**
        static void Macros()
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Keys));

            while (true)
            {
                #region **AutoGrenade**
                //AutoGrenader
                string GrenadeKey = FileManagement.ReadSettings("GrenadeKey", "Misc");
                string AutoGrenadeHotkey = FileManagement.ReadSettings("AutoGrenadeHotkey", "Misc");
                string Timing = FileManagement.ReadSettings("Timing", "Misc");

                Keys AutoGrenadeHotkey_ = (Keys)converter.ConvertFromString(AutoGrenadeHotkey);
                if (Dashboard.AutoGrenade && Keyboard.IsKeyDown(AutoGrenadeHotkey_))
                {
                    Keyboard.keybd_event(0, Convert.ToInt32(GrenadeKey), 0, 0);
                    Thread.Sleep(Convert.ToInt32(Timing));
                    Keyboard.keybd_event(0, Convert.ToInt32(GrenadeKey), 2, 0);
                }
                #endregion **AutoGrenade**

                #region **AutoLean**
                string AutoLeanLeft = FileManagement.ReadSettings("AutoLeanLeft", "Misc");
                string AutoLeanRight = FileManagement.ReadSettings("AutoLeanRight", "Misc");
                string AutoLeanDUC = FileManagement.ReadSettings("AutoLeanDUC", "Misc");
                string AutoLeanC = FileManagement.ReadSettings("AutoLeanC", "Misc");
                string AutoLeanM = FileManagement.ReadSettings("AutoLeanM", "Misc");

                if (AutoLeanM == "RMB")
                {
                    while (Dashboard.AutoLean && Keyboard.IsKeyDown(Keys.RButton))
                    {
                        if (Dashboard.IsLeft == true)
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanLeft), 0, 0); //Q key down
                            Thread.Sleep(Convert.ToInt32(AutoLeanDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanLeft), 2, 0); //Q key up
                            Thread.Sleep(Convert.ToInt32(AutoLeanC));

                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanRight), 0, 0); //E key down
                            Thread.Sleep(Convert.ToInt32(AutoLeanDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanRight), 2, 0); //E key up
                            Thread.Sleep(Convert.ToInt32(AutoLeanC));
                        }
                        else
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanRight), 0, 0); //E key down
                            Thread.Sleep(Convert.ToInt32(AutoLeanDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanRight), 2, 0); //E key up
                            Thread.Sleep(Convert.ToInt32(AutoLeanC));

                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanLeft), 0, 0); //Q key down
                            Thread.Sleep(Convert.ToInt32(AutoLeanDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanLeft), 2, 0); //Q key up
                            Thread.Sleep(Convert.ToInt32(AutoLeanC));
                        }
                    }
                }
                else
                {
                    while (Dashboard.AutoLean && Keyboard.IsKeyDown(Keys.LButton) && Keyboard.IsKeyDown(Keys.RButton))
                    {

                        if (Dashboard.IsLeft == true)
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanLeft), 0, 0); //Q key down
                            Thread.Sleep(Convert.ToInt32(AutoLeanDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanLeft), 2, 0); //Q key up
                            Thread.Sleep(Convert.ToInt32(AutoLeanC));

                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanRight), 0, 0); //E key down
                            Thread.Sleep(Convert.ToInt32(AutoLeanDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanRight), 2, 0); //E key up
                            Thread.Sleep(Convert.ToInt32(AutoLeanC));
                        }
                        else
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanRight), 0, 0); //E key down
                            Thread.Sleep(Convert.ToInt32(AutoLeanDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanRight), 2, 0); //E key up
                            Thread.Sleep(Convert.ToInt32(AutoLeanC));

                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanLeft), 0, 0); //Q key down
                            Thread.Sleep(Convert.ToInt32(AutoLeanDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(AutoLeanLeft), 2, 0); //Q key up
                            Thread.Sleep(Convert.ToInt32(AutoLeanC));
                        }
                    }
                }
                #endregion **AutoLean**

                #region **FastPeek**
                string FastPeekLeft = FileManagement.ReadSettings("FastPeekLeft", "Misc");
                string FastPeekRight = FileManagement.ReadSettings("FastPeekRight", "Misc");
                string FastPeekDUC = FileManagement.ReadSettings("FastPeekDUC", "Misc");
                string FastPeekC = FileManagement.ReadSettings("FastPeekC", "Misc");
                string FastPeekM = FileManagement.ReadSettings("FastPeekM", "Misc");

                if (FastPeekM == "RMB")
                {
                    while (Dashboard.FastPeek && Keyboard.IsKeyDown(Keys.RButton))
                    {
                        if (Dashboard.IsLeft == true)
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekLeft), 0, 0); //Q key down
                            Thread.Sleep(Convert.ToInt32(FastPeekDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekLeft), 2, 0); //Q key up
                            Thread.Sleep(Convert.ToInt32(FastPeekC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekLeft), 0, 0); //Q key down
                            Thread.Sleep(Convert.ToInt32(FastPeekDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekLeft), 2, 0); //Q key up
                            Thread.Sleep(Convert.ToInt32(FastPeekC));
                        }
                        else
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekRight), 0, 0); //E key down
                            Thread.Sleep(Convert.ToInt32(FastPeekDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekRight), 2, 0); //E key up
                            Thread.Sleep(Convert.ToInt32(FastPeekC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekRight), 0, 0); //E key down
                            Thread.Sleep(Convert.ToInt32(FastPeekDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekRight), 2, 0); //E key up
                            Thread.Sleep(Convert.ToInt32(FastPeekC));
                        }
                    }
                }
                else
                {
                    while (Dashboard.FastPeek && Keyboard.IsKeyDown(Keys.LButton) && Keyboard.IsKeyDown(Keys.RButton))
                    {
                        if (Dashboard.IsLeft == true)
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekLeft), 0, 0); //Q key down
                            Thread.Sleep(Convert.ToInt32(FastPeekDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekLeft), 2, 0); //Q key up
                            Thread.Sleep(Convert.ToInt32(FastPeekC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekLeft), 0, 0); //Q key down
                            Thread.Sleep(Convert.ToInt32(FastPeekDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekLeft), 2, 0); //Q key up
                            Thread.Sleep(Convert.ToInt32(FastPeekC));
                        }
                        else
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekRight), 0, 0); //E key down
                            Thread.Sleep(Convert.ToInt32(FastPeekDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekRight), 2, 0); //E key up
                            Thread.Sleep(Convert.ToInt32(FastPeekC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekRight), 0, 0); //E key down
                            Thread.Sleep(Convert.ToInt32(FastPeekDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(FastPeekRight), 2, 0); //E key up
                            Thread.Sleep(Convert.ToInt32(FastPeekC));
                        }
                    }
                }
                #endregion **FastPeek**

                #region **Strafe**
                string StrafeLeft = FileManagement.ReadSettings("StrafeLeft", "Misc");
                string StrafeRight = FileManagement.ReadSettings("StrafeRight", "Misc");
                string StrafeDUC = FileManagement.ReadSettings("StrafeDUC", "Misc");
                string StrafeC = FileManagement.ReadSettings("StrafeC", "Misc");
                string StrafeM = FileManagement.ReadSettings("StrafeM", "Misc");

                if (StrafeM == "RMB")
                {
                    while (Dashboard.Strafe && Keyboard.IsKeyDown(Keys.RButton))
                    {
                        if (Dashboard.IsLeft == true)
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeLeft), 0, 0); //A key down
                            Thread.Sleep(Convert.ToInt32(StrafeDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeLeft), 2, 0); //A key up
                            Thread.Sleep(Convert.ToInt32(StrafeC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeRight), 0, 0); //D key down
                            Thread.Sleep(Convert.ToInt32(StrafeDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeRight), 2, 0); //D key up
                            Thread.Sleep(Convert.ToInt32(StrafeC));
                        }
                        else
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeRight), 0, 0); //D key down
                            Thread.Sleep(Convert.ToInt32(StrafeDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeRight), 2, 0); //D key up
                            Thread.Sleep(Convert.ToInt32(StrafeC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeLeft), 0, 0); //A key down
                            Thread.Sleep(Convert.ToInt32(StrafeDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeLeft), 2, 0); //A key up
                            Thread.Sleep(Convert.ToInt32(StrafeC));
                        }
                    }
                }
                else
                {
                    while (Dashboard.Strafe && Keyboard.IsKeyDown(Keys.LButton) && Keyboard.IsKeyDown(Keys.RButton))
                    {
                        if (Dashboard.IsLeft == true)
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeLeft), 0, 0); //A key down
                            Thread.Sleep(Convert.ToInt32(StrafeDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeLeft), 2, 0); //A key up
                            Thread.Sleep(Convert.ToInt32(StrafeC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeRight), 0, 0); //D key down
                            Thread.Sleep(Convert.ToInt32(StrafeDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeRight), 2, 0); //D key up
                            Thread.Sleep(Convert.ToInt32(StrafeC));
                        }
                        else
                        {
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeRight), 0, 0); //D key down
                            Thread.Sleep(Convert.ToInt32(StrafeDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeRight), 2, 0); //D key up
                            Thread.Sleep(Convert.ToInt32(StrafeC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeLeft), 0, 0); //A key down
                            Thread.Sleep(Convert.ToInt32(StrafeDUC));
                            Keyboard.keybd_event(0, Convert.ToInt32(StrafeLeft), 2, 0); //A key up
                            Thread.Sleep(Convert.ToInt32(StrafeC));
                        }
                    }
                }

                #endregion **Strafe**
            }
        }
        #endregion **MAcros**
    }
}
