using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace _7Scripts
{
    public partial class Dashboard : MetroSetForm
    {
        //value transfer
        public static bool enabled = false;
        public static bool AutoGrenade = false;
        public static bool AutoLean = false;
        public static bool FastPeek = false;
        public static bool Strafe = false;
        public static bool IsLeft = false;

        public static int Xpull = 0;
        public static int Ypull = 0;
        public static int Cooldown = 0;
        public static int Delay = 0;

        public static List<string> weapons = new List<string>();
        public static List<string> sights = new List<string>();
        public static List<string> barrels = new List<string>();
        public static List<string> grips = new List<string>();
        public static List<string> underBarrels = new List<string>();
        public static string selectedoperator = "";
        public static string selectedweapon = "";

        //Private
        string ToggleScriptKey = "";
        string HideScriptKey = "";
        string Preset1Key = "";
        string Preset2Key = "";
        string Preset3Key = "";
        string Preset4Key = "";
        string Preset5Key = "";
        string Preset6Key = "";
        string Preset7Key = "";
        string Preset8Key = "";
        string AutoGrenadeKey = "";
        string AutoLeanKey = "";
        string FastPeekKey = "";
        string StrafeKey = "";
        string LeftKey = "";
        string RightKey = "";

        TypeConverter converter = TypeDescriptor.GetConverter(typeof(Keys));

        #region **HotkeyHandle**
        private void HKhandle()
        {
            //Hotkey Handle (Invoker: https://stackoverflow.com/questions/661561/how-do-i-update-the-gui-from-another-thread)
            while (true)
            {
                Thread.Sleep(1);
                if (ToggleScriptKey != "")
                {
                    //Converts String to Keys and checks if the key is pressed
                    Keys ToggleScript = (Keys)converter.ConvertFromString(ToggleScriptKey);
                    if (Keyboard.IsKeyDown(ToggleScript))
                    {
                        if (metroSetCheckBox1.Checked)
                        {
                            metroSetCheckBox1.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox1.Checked = false;
                            });
                        }
                        else
                        {
                            metroSetCheckBox1.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox1.Checked = true;
                            });
                        }
                        Thread.Sleep(300);
                    }
                }

                if(HideScriptKey != "")
                {
                    //Converts String to Keys and checks if the key is pressed
                    Keys HideScript = (Keys)converter.ConvertFromString(HideScriptKey);
                    if (Keyboard.IsKeyDown(HideScript))
                    {
                        if (metroSetCheckBox2.Checked)
                        {
                            metroSetCheckBox2.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox2.Checked = false;
                            });
                        }
                        else
                        {
                            metroSetCheckBox2.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox2.Checked = true;
                            });
                        }
                        Thread.Sleep(300);
                    }
                }

                if(AutoGrenadeKey != "")
                {
                    //Converts String to Keys and checks if the key is pressed
                    Keys AutoGrenade = (Keys)converter.ConvertFromString(AutoGrenadeKey);
                    if (Keyboard.IsKeyDown(AutoGrenade))
                    {
                        if (metroSetCheckBox3.Checked)
                        {
                            metroSetCheckBox3.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox3.Checked = false;
                            });
                        }
                        else
                        {
                            metroSetCheckBox3.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox3.Checked = true;
                            });
                        }
                        Thread.Sleep(300);
                    }
                }

                if (AutoLeanKey != "")
                {
                    //Converts String to Keys and checks if the key is pressed
                    Keys AutoLean = (Keys)converter.ConvertFromString(AutoLeanKey);
                    if (Keyboard.IsKeyDown(AutoLean))
                    {
                        if (metroSetCheckBox4.Checked)
                        {
                            metroSetCheckBox4.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox4.Checked = false;
                            });
                        }
                        else
                        {
                            metroSetCheckBox4.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox4.Checked = true;
                            });
                        }
                        Thread.Sleep(300);
                    }
                }

                if (FastPeekKey != "")
                {
                    //Converts String to Keys and checks if the key is pressed
                    Keys FastPeek = (Keys)converter.ConvertFromString(FastPeekKey);
                    if (Keyboard.IsKeyDown(FastPeek))
                    {
                        if (metroSetCheckBox5.Checked)
                        {
                            metroSetCheckBox5.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox5.Checked = false;
                            });
                        }
                        else
                        {
                            metroSetCheckBox5.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox5.Checked = true;
                            });
                        }
                        Thread.Sleep(300);
                    }
                }

                if (StrafeKey != "")
                {
                    //Converts String to Keys and checks if the key is pressed
                    Keys Strafe = (Keys)converter.ConvertFromString(StrafeKey);
                    if (Keyboard.IsKeyDown(Strafe))
                    {
                        if (metroSetCheckBox6.Checked)
                        {
                            metroSetCheckBox6.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox6.Checked = false;
                            });
                        }
                        else
                        {
                            metroSetCheckBox6.Invoke((MethodInvoker)delegate
                            {
                                metroSetCheckBox6.Checked = true;
                            });
                        }
                        Thread.Sleep(300);
                    }
                }

                if (Preset1Key != "")
                {
                    if (metroSetComboBox7.Enabled == true)
                    {
                        //Converts String to Keys and checks if the key is pressed
                        Keys Preset1 = (Keys)converter.ConvertFromString(Preset1Key);
                        if (Keyboard.IsKeyDown(Preset1))
                        {
                            TTS.Speak("Preset1");
                            string line1 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset1.ini").Skip(0).Take(1).First();  //Class
                            string line2 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset1.ini").Skip(1).Take(1).First();  //Operator
                            string line3 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset1.ini").Skip(2).Take(1).First();  //Weapon
                            string line4 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset1.ini").Skip(3).Take(1).First();  //Sight
                            string line5 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset1.ini").Skip(4).Take(1).First();  //Barrel
                            string line6 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset1.ini").Skip(5).Take(1).First();  //Grip
                            string line7 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset1.ini").Skip(6).Take(1).First();  //Under Barrel

                            metroSetComboBox11.Text = line1;
                            metroSetComboBox12.Text = line2;
                            metroSetComboBox13.Text = line3;
                            metroSetComboBox14.Text = line4;
                            metroSetComboBox19.Text = line5;
                            metroSetComboBox20.Text = line6;
                            metroSetComboBox21.Text = line7;
                            LoadPresets();
                            Thread.Sleep(300);
                        }
                    }
                }

                if (Preset2Key != "")
                {
                    if (metroSetComboBox8.Enabled == true)
                    {
                        //Converts String to Keys and checks if the key is pressed
                        Keys Preset2 = (Keys)converter.ConvertFromString(Preset2Key);
                        if (Keyboard.IsKeyDown(Preset2))
                        {
                            TTS.Speak("Preset2");
                            string line1 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset2.ini").Skip(0).Take(1).First();  //Class
                            string line2 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset2.ini").Skip(1).Take(1).First();  //Operator
                            string line3 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset2.ini").Skip(2).Take(1).First();  //Weapon
                            string line4 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset2.ini").Skip(3).Take(1).First();  //Sight
                            string line5 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset2.ini").Skip(4).Take(1).First();  //Barrel
                            string line6 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset2.ini").Skip(5).Take(1).First();  //Grip
                            string line7 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset2.ini").Skip(6).Take(1).First();  //Under Barrel

                            metroSetComboBox11.Text = line1;
                            metroSetComboBox12.Text = line2;
                            metroSetComboBox13.Text = line3;
                            metroSetComboBox14.Text = line4;
                            metroSetComboBox19.Text = line5;
                            metroSetComboBox20.Text = line6;
                            metroSetComboBox21.Text = line7;
                            LoadPresets();
                            Thread.Sleep(300);
                        }
                    }
                }

                if (Preset3Key != "")
                {
                    if (metroSetComboBox9.Enabled == true)
                    {
                        //Converts String to Keys and checks if the key is pressed
                        Keys Preset3 = (Keys)converter.ConvertFromString(Preset3Key);
                        if (Keyboard.IsKeyDown(Preset3))
                        {
                            TTS.Speak("Preset3");
                            string line1 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset3.ini").Skip(0).Take(1).First();  //Class
                            string line2 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset3.ini").Skip(1).Take(1).First();  //Operator
                            string line3 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset3.ini").Skip(2).Take(1).First();  //Weapon
                            string line4 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset3.ini").Skip(3).Take(1).First();  //Sight
                            string line5 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset3.ini").Skip(4).Take(1).First();  //Barrel
                            string line6 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset3.ini").Skip(5).Take(1).First();  //Grip
                            string line7 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset3.ini").Skip(6).Take(1).First();  //Under Barrel

                            metroSetComboBox11.Text = line1;
                            metroSetComboBox12.Text = line2;
                            metroSetComboBox13.Text = line3;
                            metroSetComboBox14.Text = line4;
                            metroSetComboBox19.Text = line5;
                            metroSetComboBox20.Text = line6;
                            metroSetComboBox21.Text = line7;
                            LoadPresets();
                            Thread.Sleep(300);
                        }
                    }
                }

                if (Preset4Key != "")
                {
                    if (metroSetComboBox10.Enabled == true)
                    {
                        //Converts String to Keys and checks if the key is pressed
                        Keys Preset4 = (Keys)converter.ConvertFromString(Preset4Key);
                        if (Keyboard.IsKeyDown(Preset4))
                        {
                            TTS.Speak("Preset4");
                            string line1 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset4.ini").Skip(0).Take(1).First();  //Class
                            string line2 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset4.ini").Skip(1).Take(1).First();  //Operator
                            string line3 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset4.ini").Skip(2).Take(1).First();  //Weapon
                            string line4 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset4.ini").Skip(3).Take(1).First();  //Sight
                            string line5 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset4.ini").Skip(4).Take(1).First();  //Barrel
                            string line6 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset4.ini").Skip(5).Take(1).First();  //Grip
                            string line7 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset4.ini").Skip(6).Take(1).First();  //Under Barrel

                            metroSetComboBox11.Text = line1;
                            metroSetComboBox12.Text = line2;
                            metroSetComboBox13.Text = line3;
                            metroSetComboBox14.Text = line4;
                            metroSetComboBox19.Text = line5;
                            metroSetComboBox20.Text = line6;
                            metroSetComboBox21.Text = line7;
                            LoadPresets();
                            Thread.Sleep(300);
                        }
                    }
                }

                if (Preset5Key != "")
                {
                    if (metroSetComboBox40.Enabled == true)
                    {
                        //Converts String to Keys and checks if the key is pressed
                        Keys Preset5 = (Keys)converter.ConvertFromString(Preset5Key);
                        if (Keyboard.IsKeyDown(Preset5))
                        {
                            TTS.Speak("Preset5");
                            string line1 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset5.ini").Skip(0).Take(1).First();  //Class
                            string line2 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset5.ini").Skip(1).Take(1).First();  //Operator
                            string line3 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset5.ini").Skip(2).Take(1).First();  //Weapon
                            string line4 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset5.ini").Skip(3).Take(1).First();  //Sight
                            string line5 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset5.ini").Skip(4).Take(1).First();  //Barrel
                            string line6 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset5.ini").Skip(5).Take(1).First();  //Grip
                            string line7 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset5.ini").Skip(6).Take(1).First();  //Under Barrel

                            metroSetComboBox11.Text = line1;
                            metroSetComboBox12.Text = line2;
                            metroSetComboBox13.Text = line3;
                            metroSetComboBox14.Text = line4;
                            metroSetComboBox19.Text = line5;
                            metroSetComboBox20.Text = line6;
                            metroSetComboBox21.Text = line7;
                            LoadPresets();
                            Thread.Sleep(300);
                        }
                    }
                }

                if (Preset6Key != "")
                {
                    if (metroSetComboBox41.Enabled == true)
                    {
                        //Converts String to Keys and checks if the key is pressed
                        Keys Preset6 = (Keys)converter.ConvertFromString(Preset6Key);
                        if (Keyboard.IsKeyDown(Preset6))
                        {
                            TTS.Speak("Preset6");
                            string line1 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset6.ini").Skip(0).Take(1).First();  //Class
                            string line2 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset6.ini").Skip(1).Take(1).First();  //Operator
                            string line3 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset6.ini").Skip(2).Take(1).First();  //Weapon
                            string line4 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset6.ini").Skip(3).Take(1).First();  //Sight
                            string line5 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset6.ini").Skip(4).Take(1).First();  //Barrel
                            string line6 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset6.ini").Skip(5).Take(1).First();  //Grip
                            string line7 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset6.ini").Skip(6).Take(1).First();  //Under Barrel

                            metroSetComboBox11.Text = line1;
                            metroSetComboBox12.Text = line2;
                            metroSetComboBox13.Text = line3;
                            metroSetComboBox14.Text = line4;
                            metroSetComboBox19.Text = line5;
                            metroSetComboBox20.Text = line6;
                            metroSetComboBox21.Text = line7;
                            LoadPresets();
                            Thread.Sleep(300);
                        }
                    }
                }

                if (Preset7Key != "")
                {
                    if (metroSetComboBox42.Enabled == true)
                    {
                        //Converts String to Keys and checks if the key is pressed
                        Keys Preset7 = (Keys)converter.ConvertFromString(Preset7Key);
                        if (Keyboard.IsKeyDown(Preset7))
                        {
                            TTS.Speak("Preset7");
                            string line1 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset7.ini").Skip(0).Take(1).First();  //Class
                            string line2 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset7.ini").Skip(1).Take(1).First();  //Operator
                            string line3 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset7.ini").Skip(2).Take(1).First();  //Weapon
                            string line4 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset7.ini").Skip(3).Take(1).First();  //Sight
                            string line5 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset7.ini").Skip(4).Take(1).First();  //Barrel
                            string line6 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset7.ini").Skip(5).Take(1).First();  //Grip
                            string line7 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset7.ini").Skip(6).Take(1).First();  //Under Barrel

                            metroSetComboBox11.Text = line1;
                            metroSetComboBox12.Text = line2;
                            metroSetComboBox13.Text = line3;
                            metroSetComboBox14.Text = line4;
                            metroSetComboBox19.Text = line5;
                            metroSetComboBox20.Text = line6;
                            metroSetComboBox21.Text = line7;
                            LoadPresets();
                            Thread.Sleep(300);
                        }
                    }
                }

                if (Preset8Key != "")
                {
                    if (metroSetComboBox43.Enabled == true)
                    {
                        //Converts String to Keys and checks if the key is pressed
                        Keys Preset8 = (Keys)converter.ConvertFromString(Preset8Key);
                        if (Keyboard.IsKeyDown(Preset8))
                        {
                            TTS.Speak("Preset8");
                            string line1 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset8.ini").Skip(0).Take(1).First();  //Class
                            string line2 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset8.ini").Skip(1).Take(1).First();  //Operator
                            string line3 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset8.ini").Skip(2).Take(1).First();  //Weapon
                            string line4 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset8.ini").Skip(3).Take(1).First();  //Sight
                            string line5 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset8.ini").Skip(4).Take(1).First();  //Barrel
                            string line6 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset8.ini").Skip(5).Take(1).First();  //Grip
                            string line7 = File.ReadLines(@"C:\7Scripts\Light\binds\Preset8.ini").Skip(6).Take(1).First();  //Under Barrel

                            metroSetComboBox11.Text = line1;
                            metroSetComboBox12.Text = line2;
                            metroSetComboBox13.Text = line3;
                            metroSetComboBox14.Text = line4;
                            metroSetComboBox19.Text = line5;
                            metroSetComboBox20.Text = line6;
                            metroSetComboBox21.Text = line7;
                            LoadPresets();
                            Thread.Sleep(300);
                        }
                    }
                }

                if (LeftKey != "")
                {
                    //Converts String to Keys and checks if the key is pressed
                    Keys LeftKey_ = (Keys)converter.ConvertFromString(LeftKey);
                    if (Keyboard.IsKeyDown(LeftKey_))
                    {
                        TTS.Speak("Left");
                        IsLeft = true;
                        Thread.Sleep(300);
                    }
                }

                if (RightKey != "")
                {
                    //Converts String to Keys and checks if the key is pressed
                    Keys RightKey_ = (Keys)converter.ConvertFromString(RightKey);
                    if (Keyboard.IsKeyDown(RightKey_))
                    {
                        TTS.Speak("Right");
                        IsLeft = false;
                        Thread.Sleep(300);
                    }
                }
            }
        }
        #endregion **HotkeyHandle**

        #region **Hotkey Loader**
        private void LoadHKs()
        {
            //Converts Enum to List and addds them to the ComboBoxes that need them
            var SortedKeys = Enum.GetValues(typeof(Keys)).Cast<Keys>().OrderBy(n => n);
            foreach (var item in SortedKeys)
            {
                //Adds Key List to Combobox

                //Main
                metroSetComboBox1.Items.Add(item);
                metroSetComboBox6.Items.Add(item);
                metroSetComboBox24.Items.Add(item);
                metroSetComboBox23.Items.Add(item);
                metroSetComboBox26.Items.Add(item);
                metroSetComboBox25.Items.Add(item);

                //Misc
                metroSetComboBox7.Items.Add(item);
                metroSetComboBox8.Items.Add(item);
                metroSetComboBox9.Items.Add(item);
                metroSetComboBox10.Items.Add(item);
                metroSetComboBox27.Items.Add(item);
                metroSetComboBox38.Items.Add(item);
                metroSetComboBox39.Items.Add(item);
                metroSetComboBox40.Items.Add(item);
                metroSetComboBox41.Items.Add(item);
                metroSetComboBox42.Items.Add(item);
                metroSetComboBox43.Items.Add(item);
            }

            //Wont try to read the Hotkeys if the File doesn't exist
            if (File.Exists(@"C:\7Scripts\Light\Settings.ini"))
            {
                //Selects Saved Item

                //Main
                metroSetComboBox1.Text = FileManagement.ReadSettings("Enable", "Hotkeys");
                metroSetComboBox6.Text = FileManagement.ReadSettings("Hide", "Hotkeys");
                metroSetComboBox24.Text = FileManagement.ReadSettings("AutoGrenade", "Hotkeys");
                metroSetComboBox23.Text = FileManagement.ReadSettings("AutoLean", "Hotkeys");
                metroSetComboBox26.Text = FileManagement.ReadSettings("FastPeek", "Hotkeys");
                metroSetComboBox25.Text = FileManagement.ReadSettings("Strafe", "Hotkeys");

                //Misc
                metroSetComboBox7.Text = FileManagement.ReadSettings("Preset1", "Hotkeys");
                metroSetComboBox8.Text = FileManagement.ReadSettings("Preset2", "Hotkeys");
                metroSetComboBox9.Text = FileManagement.ReadSettings("Preset3", "Hotkeys");
                metroSetComboBox10.Text = FileManagement.ReadSettings("Preset4", "Hotkeys");
                metroSetComboBox40.Text = FileManagement.ReadSettings("Preset5", "Hotkeys");
                metroSetComboBox41.Text = FileManagement.ReadSettings("Preset6", "Hotkeys");
                metroSetComboBox42.Text = FileManagement.ReadSettings("Preset7", "Hotkeys");
                metroSetComboBox43.Text = FileManagement.ReadSettings("Preset8", "Hotkeys");
                metroSetComboBox28.Text = FileManagement.ReadSettings("GrenadeKey", "Misc");
                metroSetComboBox27.Text = FileManagement.ReadSettings("AutoGrenadeHotkey", "Misc");
                numericUpDown5.Value = Convert.ToDecimal(FileManagement.ReadSettings("Timing", "Misc"));
                metroSetComboBox29.Text = FileManagement.ReadSettings("AutoLeanLeft", "Misc");
                metroSetComboBox30.Text = FileManagement.ReadSettings("AutoLeanRight", "Misc");
                numericUpDown6.Value = Convert.ToDecimal(FileManagement.ReadSettings("AutoLeanDUC", "Misc"));
                numericUpDown7.Value = Convert.ToDecimal(FileManagement.ReadSettings("AutoLeanC", "Misc"));
                metroSetComboBox31.Text = FileManagement.ReadSettings("AutoLeanM", "Misc");
                metroSetComboBox34.Text = FileManagement.ReadSettings("FastPeekLeft", "Misc");
                metroSetComboBox33.Text = FileManagement.ReadSettings("FastPeekRight", "Misc");
                numericUpDown9.Value = Convert.ToDecimal(FileManagement.ReadSettings("FastPeekDUC", "Misc"));
                numericUpDown8.Value = Convert.ToDecimal(FileManagement.ReadSettings("FastPeekC", "Misc"));
                metroSetComboBox32.Text = FileManagement.ReadSettings("FastPeekM", "Misc");
                metroSetComboBox37.Text = FileManagement.ReadSettings("StrafeLeft", "Misc");
                metroSetComboBox36.Text = FileManagement.ReadSettings("StrafeRight", "Misc");
                numericUpDown11.Value = Convert.ToDecimal(FileManagement.ReadSettings("StrafeDUC", "Misc"));
                numericUpDown10.Value = Convert.ToDecimal(FileManagement.ReadSettings("StrafeC", "Misc"));
                metroSetComboBox35.Text = FileManagement.ReadSettings("StrafeM", "Misc");
                metroSetComboBox38.Text = FileManagement.ReadSettings("StartLeftHotkey", "Misc");
                metroSetComboBox39.Text = FileManagement.ReadSettings("StartRightHotkey", "Misc");
            }
            else
            {
                //Load Default
            }
        }
        #endregion **Hotkey Loader**

        #region **Bind Checker**
        private void CheckBinds()
        {
            metroSetComboBox22.Items.Clear();

            //Lists available binds to selector
            if (!File.Exists(@"C:\7Scripts\Light\binds\Preset1.ini"))
            {
                metroSetComboBox22.Items.Add("Preset1");
                metroSetComboBox7.Enabled = false;
            }
            else
            {
                metroSetComboBox22.Items.Remove("Preset1");
                metroSetComboBox7.Enabled = true;
            }
            if (!File.Exists(@"C:\7Scripts\Light\binds\Preset2.ini"))
            {
                metroSetComboBox22.Items.Add("Preset2");
                metroSetComboBox8.Enabled = false;
            }
            else
            {
                metroSetComboBox22.Items.Remove("Preset2");
                metroSetComboBox8.Enabled = true;
            }
            if (!File.Exists(@"C:\7Scripts\Light\binds\Preset3.ini"))
            {
                metroSetComboBox22.Items.Add("Preset3");
                metroSetComboBox9.Enabled = false;
            }
            else
            {
                metroSetComboBox22.Items.Remove("Preset3");
                metroSetComboBox9.Enabled = true;
            }
            if (!File.Exists(@"C:\7Scripts\Light\binds\Preset4.ini"))
            {
                metroSetComboBox22.Items.Add("Preset4");
                metroSetComboBox10.Enabled = false;
            }
            else
            {
                metroSetComboBox22.Items.Remove("Preset4");
                metroSetComboBox10.Enabled = true;
            }
            if (!File.Exists(@"C:\7Scripts\Light\binds\Preset5.ini"))
            {
                metroSetComboBox22.Items.Add("Preset5");
                metroSetComboBox40.Enabled = false;
            }
            else
            {
                metroSetComboBox22.Items.Remove("Preset5");
                metroSetComboBox40.Enabled = true;
            }
            if (!File.Exists(@"C:\7Scripts\Light\binds\Preset6.ini"))
            {
                metroSetComboBox22.Items.Add("Preset6");
                metroSetComboBox41.Enabled = false;
            }
            else
            {
                metroSetComboBox22.Items.Remove("Preset6");
                metroSetComboBox41.Enabled = true;
            }
            if (!File.Exists(@"C:\7Scripts\Light\binds\Preset7.ini"))
            {
                metroSetComboBox22.Items.Add("Preset7");
                metroSetComboBox42.Enabled = false;
            }
            else
            {
                metroSetComboBox22.Items.Remove("Preset7");
                metroSetComboBox42.Enabled = true;
            }
            if (!File.Exists(@"C:\7Scripts\Light\binds\Preset8.ini"))
            {
                metroSetComboBox22.Items.Add("Preset8");
                metroSetComboBox43.Enabled = false;
            }
            else
            {
                metroSetComboBox22.Items.Remove("Preset8");
                metroSetComboBox43.Enabled = true;
            }
            Refresh();
        }
        #endregion **Bind Checker**

        #region **lineChanger**
        private void lineChanger(string newText, string fileName, int line_to_edit)
        {
            //Can change lines in a File
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
        #endregion **lineChanger**

        #region **Dashboard**
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Starts updateName Thread
            Thread _updateName = new Thread(updateName);
            _updateName.SetApartmentState(ApartmentState.STA); //Sets the thread to STA type to fix the DragDrop registration exeption
            _updateName.IsBackground = true;
            _updateName.Start();

            void updateName()
            {
                //rndm form name gen
                while (true)
                {
                    string rndCHAR = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

                    string rnd = "";
                    for (int i = 0; i < 10; i++)
                    {
                        Random random = new Random();
                        int index = random.Next(0, rndCHAR.Length);

                        rnd += rndCHAR.ToArray()[index];
                    }

                    this.Text = rnd;
                    Console.Title = rnd;
                    //this.Refresh(); DONT USE IF YOU WANT TO SHOW LOGIN
                    Thread.Sleep(500);
                }
            }

            Program.Start();

            CheckBinds();

            //Hotkeys
            LoadHKs();
            Thread HK_handle = new Thread(HKhandle);
            HK_handle.SetApartmentState(ApartmentState.STA); //Sets the thread to STA type to fix the DragDrop registration exeption
            HK_handle.IsBackground = true;
            HK_handle.Start();

            //Load
            metroSetComboBox18.Text = "Default";

            //--------------------------------------------
            metroSetCheckBox2.Text = "Currently disabled";
            metroSetCheckBox2.ForeColor = Color.DarkRed;
            //--------------------------------------------
        }
        #endregion

        #region **Lists Operators, Weapons etc**
        private void metroSetComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load Operators
            metroSetComboBox3.Items.Clear();
            metroSetComboBox4.Items.Clear();
            metroSetComboBox5.Items.Clear();
            metroSetComboBox15.Items.Clear();
            metroSetComboBox16.Items.Clear();
            metroSetComboBox17.Items.Clear();
            Refresh();

            if (metroSetComboBox2.SelectedItem == "Defenders")
            {
                //Sorts from A to Z
                var SortedDefenders = Operators.GetDefenders.OrderBy(n => n);
                foreach (var item in SortedDefenders)
                {
                    metroSetComboBox3.Items.Add(item);
                }
            }
            else if (metroSetComboBox2.SelectedItem == "Attackers")
            {
                //Sorts from A to Z
                var SortedAttackers = Operators.GetAttackers.OrderBy(n => n);
                foreach (var item in SortedAttackers)
                {
                    metroSetComboBox3.Items.Add(item);
                }
            }
        }

        private void metroSetComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lists Operators & Load Weapons
            metroSetComboBox4.Items.Clear();
            metroSetComboBox5.Items.Clear();
            metroSetComboBox15.Items.Clear();
            metroSetComboBox16.Items.Clear();
            metroSetComboBox17.Items.Clear();
            Refresh();

            selectedoperator = metroSetComboBox3.Text;

            if (metroSetComboBox2.SelectedItem == "Attackers")
            {
                Operators.Attackers();

                for (int i = 0; i < weapons.Count; i++)
                {
                    metroSetComboBox4.Items.Add(weapons.ElementAt(i));
                }
            }
            else if (metroSetComboBox2.SelectedItem == "Defenders")
            {
                Operators.Defenders();

                for (int i = 0; i < weapons.Count; i++)
                {
                    metroSetComboBox4.Items.Add(weapons.ElementAt(i));
                }
            }
        }

        private void metroSetComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lists Weapons & Load sights, barrels, grips, under barrels
            metroSetComboBox5.Items.Clear();
            metroSetComboBox15.Items.Clear();
            metroSetComboBox16.Items.Clear();
            metroSetComboBox17.Items.Clear();
            Refresh();

            selectedweapon = metroSetComboBox4.Text;
            Weapons.GetValues();

            for (int i = 0; i < sights.Count; i++)
            {
                metroSetComboBox5.Items.Add(sights.ElementAt(i));
            }
            for (int i = 0; i < barrels.Count; i++)
            {
                metroSetComboBox15.Items.Add(barrels.ElementAt(i));
            }
            for (int i = 0; i < grips.Count; i++)
            {
                metroSetComboBox16.Items.Add(grips.ElementAt(i));
            }
            for (int i = 0; i < underBarrels.Count; i++)
            {
                metroSetComboBox17.Items.Add(underBarrels.ElementAt(i));
            }
        }
        #endregion **Lists Operators, Weapons etc**

        #region **Hotkeys Selector**
        private void metroSetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            ToggleScriptKey = metroSetComboBox1.Text;
            FileManagement.WriteSettings("Enable", metroSetComboBox1.Text, "Hotkeys");
        }

        private void metroSetComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            HideScriptKey = metroSetComboBox6.Text;
            FileManagement.WriteSettings("Hide", metroSetComboBox6.Text, "Hotkeys");
        }

        private void metroSetComboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            AutoGrenadeKey = metroSetComboBox24.Text;
            FileManagement.WriteSettings("AutoGrenade", metroSetComboBox24.Text, "Hotkeys");
        }

        private void metroSetComboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            AutoLeanKey = metroSetComboBox23.Text;
            FileManagement.WriteSettings("AutoLean", metroSetComboBox23.Text, "Hotkeys");
        }

        private void metroSetComboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            FastPeekKey = metroSetComboBox26.Text;
            FileManagement.WriteSettings("FastPeek", metroSetComboBox26.Text, "Hotkeys");
        }

        private void metroSetComboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            StrafeKey = metroSetComboBox25.Text;
            FileManagement.WriteSettings("Strafe", metroSetComboBox25.Text, "Hotkeys");
        }

        //Misc
        private void metroSetComboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
        }

        private void metroSetComboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            LeftKey = metroSetComboBox38.Text;
        }

        private void metroSetComboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            RightKey = metroSetComboBox39.Text;
        }

        private void metroSetComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            Preset1Key = metroSetComboBox7.Text;
            FileManagement.WriteSettings("Preset1", metroSetComboBox7.Text, "Hotkeys");
        }

        private void metroSetComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            Preset2Key = metroSetComboBox8.Text;
            FileManagement.WriteSettings("Preset2", metroSetComboBox8.Text, "Hotkeys");
        }

        private void metroSetComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            Preset3Key = metroSetComboBox9.Text;
            FileManagement.WriteSettings("Preset3", metroSetComboBox9.Text, "Hotkeys");
        }

        private void metroSetComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            Preset4Key = metroSetComboBox10.Text;
            FileManagement.WriteSettings("Preset4", metroSetComboBox10.Text, "Hotkeys");
        }

        private void metroSetComboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            Preset5Key = metroSetComboBox40.Text;
            FileManagement.WriteSettings("Preset5", metroSetComboBox40.Text, "Hotkeys");
        }

        private void metroSetComboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            Preset6Key = metroSetComboBox41.Text;
            FileManagement.WriteSettings("Preset6", metroSetComboBox41.Text, "Hotkeys");
        }

        private void metroSetComboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            Preset7Key = metroSetComboBox42.Text;
            FileManagement.WriteSettings("Preset7", metroSetComboBox42.Text, "Hotkeys");
        }

        private void metroSetComboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected HotKey
            this.ActiveControl = null; //Removes Focus either ways it will change the hk on press eg from num1 to 1
            Preset8Key = metroSetComboBox43.Text;
            FileManagement.WriteSettings("Preset8", metroSetComboBox43.Text, "Hotkeys");
        }
        #endregion **Hotkeys Selector**

        #region **CheckBox**
        private void metroSetCheckBox1_CheckedChanged(object sender)
        {
            //Enables Script
            if (metroSetCheckBox1.Checked == true)
            {
                enabled = true;
                Console.Beep(1000, 100);
            }
            else
            {
                enabled = false;
                Console.Beep(500, 100);
            }
        }

        private void metroSetCheckBox2_CheckedChanged(object sender)
        {
            //Hides Script
            if (metroSetCheckBox2.Checked == true)
            {
                //--------------------------------
                metroSetCheckBox2.Checked = false;
                //--------------------------------

                /*
                //Dashboard
                this.Opacity = 0;
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                this.WindowState = FormWindowState.Maximized;
                this.ShowInTaskbar = false;
                //Console
                var handle = Program.GetConsoleWindow();
                Program.ShowWindow(handle, 0);
                */
            }
            else
            {
                /*
                //Dashboard
                this.Opacity = 1;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.ShowInTaskbar = true;
                //Console
                var handle = Program.GetConsoleWindow();
                Program.ShowWindow(handle, 5);
                */
            }
        }

        private void metroSetCheckBox3_CheckedChanged(object sender)
        {
            if (metroSetCheckBox3.Checked == true) 
            {
                AutoGrenade = true;
                TTS.Speak("Auto grenade on");
            }
            else
            {
                AutoGrenade = false;
                TTS.Speak("Auto grenade off");
            }
        }

        private void metroSetCheckBox4_CheckedChanged(object sender)
        {
            if (metroSetCheckBox4.Checked == true)
            {
                AutoLean = true;
                TTS.Speak("Auto lean on");
            }
            else
            {
                AutoLean = false;
                TTS.Speak("Auto lean off");
            }
        }

        private void metroSetCheckBox5_CheckedChanged(object sender)
        {
            if (metroSetCheckBox5.Checked == true)
            {
                FastPeek = true;
                TTS.Speak("Fast peek on");
            }
            else
            {
                FastPeek = false;
                TTS.Speak("Fast peek off");
            }
        }

        private void metroSetCheckBox6_CheckedChanged(object sender)
        {
            if (metroSetCheckBox6.Checked == true)
            {
                Strafe = true;
                TTS.Speak("Strafe on");
            }
            else
            {
                Strafe = false;
                TTS.Speak("Strafe off");
            }
        }
        #endregion **CheckBox**

        #region **numericUpDown**
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //Sets Xpull
            Xpull = (int)numericUpDown3.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Sets Ypull
            Ypull = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //Sets pms
            Cooldown = (int)numericUpDown2.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Delay = (int)numericUpDown4.Value;
        }
        #endregion **numericUpDown**

        #region **trackbars**
        private void Xsenstrackbar_Scroll(object sender)
        {
            //Shows TrackBar Value
            int i = Xsenstrackbar.Value;
            Xsensninfo.Text = i.ToString();
        }

        private void Ysenstrackbar_Scroll(object sender)
        {
            //Shows TrackBar Value
            int i = Ysenstrackbar.Value;
            Ysensninfo.Text = i.ToString();
        }
        #endregion **trackbars**

        #region **Preset Generator**
        private void metroSetDefaultButton1_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox2.Text == "" || metroSetComboBox3.Text == "" || metroSetComboBox4.Text == "" || metroSetComboBox5.Text == "" || metroSetComboBox15.Text == "" || metroSetComboBox16.Text == "" || metroSetComboBox17.Text == "")
            {
                //Throws Error
                MessageBox.Show("Please select everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetPath = @"C:\7Scripts\Light\presets\" + metroSetComboBox2.Text + @"\" + metroSetComboBox3.Text + @"\" + metroSetComboBox4.Text + @"\" + metroSetComboBox5.Text + @"\" + metroSetComboBox15.Text + @"\" + metroSetComboBox16.Text + @"\" + metroSetComboBox17.Text;
                string FilePath = PresetPath + @"\Preset.ini";
                if (!Directory.Exists(PresetPath))
                {
                    //Creates Dir
                    Directory.CreateDirectory(PresetPath);

                    //Creates File and Writes to File
                    File.AppendAllText(FilePath, numericUpDown3.Value + "\n");     //[X]Pull
                    File.AppendAllText(FilePath, numericUpDown1.Value + "\n");     //[Y]Pull
                    File.AppendAllText(FilePath, numericUpDown2.Value + "\n");     //Cooldown
                    File.AppendAllText(FilePath, Xsenstrackbar.Value + "\n");      //Ingame sens [X]
                    File.AppendAllText(FilePath, Ysenstrackbar.Value + "\n");      //Ingame sens [Y]
                    File.AppendAllText(FilePath, metroSetComboBox18.Text + "\n");  //mode
                    File.AppendAllText(FilePath, metroSetTrackBar9.Value + "\n");  //default
                    File.AppendAllText(FilePath, metroSetTrackBar1.Value + "\n");  //1x
                    File.AppendAllText(FilePath, metroSetTrackBar2.Value + "\n");  //1.5x
                    File.AppendAllText(FilePath, metroSetTrackBar3.Value + "\n");  //2x
                    File.AppendAllText(FilePath, metroSetTrackBar4.Value + "\n");  //2.5x
                    File.AppendAllText(FilePath, metroSetTrackBar5.Value + "\n");  //3x
                    File.AppendAllText(FilePath, metroSetTrackBar6.Value + "\n");  //4x
                    File.AppendAllText(FilePath, metroSetTrackBar7.Value + "\n");  //5x
                    File.AppendAllText(FilePath, metroSetTrackBar8.Value + "\n");  //12x
                    File.AppendAllText(FilePath, numericUpDown4.Value + "\n");     //Delay
                }
                else
                {
                    DialogResult dr = MessageBox.Show("There is already a {[" + metroSetComboBox2.Text + "]=>[" + metroSetComboBox3.Text + "]=>[" + metroSetComboBox4.Text + "]=>[" + metroSetComboBox5.Text + "]=>[" + metroSetComboBox15.Text + "]=>[" + metroSetComboBox16.Text + "]=>[" + metroSetComboBox17.Text + "]} preset. Do you want to overwrite it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (dr)
                    {
                        //Overwrites preset
                        case DialogResult.Yes:
                            File.Delete(FilePath);
                            File.AppendAllText(FilePath, numericUpDown3.Value + "\n");     //[X]Pull
                            File.AppendAllText(FilePath, numericUpDown1.Value + "\n");     //[Y]Pull
                            File.AppendAllText(FilePath, numericUpDown2.Value + "\n");     //Cooldown
                            File.AppendAllText(FilePath, Xsenstrackbar.Value + "\n");      //Ingame sens [X]
                            File.AppendAllText(FilePath, Ysenstrackbar.Value + "\n");      //Ingame sens [Y]
                            File.AppendAllText(FilePath, metroSetComboBox18.Text + "\n");  //mode
                            File.AppendAllText(FilePath, metroSetTrackBar9.Value + "\n");  //default
                            File.AppendAllText(FilePath, metroSetTrackBar1.Value + "\n");  //1x
                            File.AppendAllText(FilePath, metroSetTrackBar2.Value + "\n");  //1.5x
                            File.AppendAllText(FilePath, metroSetTrackBar3.Value + "\n");  //2x
                            File.AppendAllText(FilePath, metroSetTrackBar4.Value + "\n");  //2.5x
                            File.AppendAllText(FilePath, metroSetTrackBar5.Value + "\n");  //3x
                            File.AppendAllText(FilePath, metroSetTrackBar6.Value + "\n");  //4x
                            File.AppendAllText(FilePath, metroSetTrackBar7.Value + "\n");  //5x
                            File.AppendAllText(FilePath, metroSetTrackBar8.Value + "\n");  //12x
                            File.AppendAllText(FilePath, numericUpDown4.Value + "\n");     //Delay
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
        }
        #endregion **Preset Generator**

        #region **Preset Reader**
        private void metroSetComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears ComboBoxes & refreshs UI
            metroSetComboBox12.Items.Clear();
            metroSetComboBox13.Items.Clear();
            metroSetComboBox14.Items.Clear();
            metroSetComboBox19.Items.Clear();
            metroSetComboBox20.Items.Clear();
            metroSetComboBox21.Items.Clear();
            Refresh();

            //Gets Top Dirs
            string[] folders = Directory.GetDirectories(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text, "*", SearchOption.TopDirectoryOnly);

            foreach (var item in folders)
            {
                //Gets every Item in the Folders array, removes the path and adds it to the next combobox 
                string str = item.Replace(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\", "");
                metroSetComboBox12.Items.Add(str);
            }
        }

        private void metroSetComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears ComboBoxes & refreshs UI
            metroSetComboBox13.Items.Clear();
            metroSetComboBox14.Items.Clear();
            metroSetComboBox19.Items.Clear();
            metroSetComboBox20.Items.Clear();
            metroSetComboBox21.Items.Clear();
            Refresh();

            //Gets Top Dirs
            string[] folders = Directory.GetDirectories(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text, "*", SearchOption.TopDirectoryOnly);

            foreach (var item in folders)
            {
                //Gets every Item in the Folders array, removes the path and adds it to the next combobox 
                string str = item.Replace(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\", "");
                metroSetComboBox13.Items.Add(str);
            }
        }

        private void metroSetComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears ComboBoxes & refreshs UI
            metroSetComboBox14.Items.Clear();
            metroSetComboBox19.Items.Clear();
            metroSetComboBox20.Items.Clear();
            metroSetComboBox21.Items.Clear();
            Refresh();

            //Gets Top Dirs
            string[] folders = Directory.GetDirectories(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text, "*", SearchOption.TopDirectoryOnly);

            foreach (var item in folders)
            {
                //Gets every Item in the Folders array, removes the path and adds it to the next combobox 
                string str = item.Replace(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text + @"\", "");
                metroSetComboBox14.Items.Add(str);
            }
        }

        private void metroSetComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears ComboBoxes & refreshs UI
            metroSetComboBox19.Items.Clear();
            metroSetComboBox20.Items.Clear();
            metroSetComboBox21.Items.Clear();
            Refresh();

            //Gets Top Dirs
            string[] folders = Directory.GetDirectories(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text + @"\" + metroSetComboBox14.Text, "*", SearchOption.TopDirectoryOnly);

            foreach (var item in folders)
            {
                //Gets every Item in the Folders array, removes the path and adds it to the next combobox 
                string str = item.Replace(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text + @"\" + metroSetComboBox14.Text + @"\", "");
                metroSetComboBox19.Items.Add(str);
            }
        }

        private void metroSetComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears ComboBoxes & refreshs UI
            metroSetComboBox20.Items.Clear();
            metroSetComboBox21.Items.Clear();
            Refresh();

            //Gets Top Dirs
            string[] folders = Directory.GetDirectories(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text + @"\" + metroSetComboBox14.Text + @"\" + metroSetComboBox19.Text, "*", SearchOption.TopDirectoryOnly);

            foreach (var item in folders)
            {
                //Gets every Item in the Folders array, removes the path and adds it to the next combobox 
                string str = item.Replace(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text + @"\" + metroSetComboBox14.Text + @"\" + metroSetComboBox19.Text + @"\", "");
                metroSetComboBox20.Items.Add(str);
            }
        }

        private void metroSetComboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears ComboBoxes & refreshs UI
            metroSetComboBox21.Items.Clear();
            Refresh();

            //Gets Top Dirs
            string[] folders = Directory.GetDirectories(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text + @"\" + metroSetComboBox14.Text + @"\" + metroSetComboBox19.Text + @"\" + metroSetComboBox20.Text, "*", SearchOption.TopDirectoryOnly);

            foreach (var item in folders)
            {
                //Gets every Item in the Folders array, removes the path and adds it to the next combobox 
                string str = item.Replace(@"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text + @"\" + metroSetComboBox14.Text + @"\" + metroSetComboBox19.Text + @"\" + metroSetComboBox20.Text + @"\", "");
                metroSetComboBox21.Items.Add(str);
            }
        }

        private void metroSetDefaultButton3_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox11.Text == "" || metroSetComboBox12.Text == "" || metroSetComboBox13.Text == "" || metroSetComboBox14.Text == "" || metroSetComboBox19.Text == "" || metroSetComboBox20.Text == "" || metroSetComboBox21.Text == "")
            {
                //Throws Error
                MessageBox.Show("Please select everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadPresets();
            }
        }

        private void LoadPresets()
        {
            string FilePath = @"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text + @"\" + metroSetComboBox14.Text + @"\" + metroSetComboBox19.Text + @"\" + metroSetComboBox20.Text + @"\" + metroSetComboBox21.Text + @"\Preset.ini";

            //Read preset.ini
            string line1 = File.ReadLines(FilePath).Skip(0).Take(1).First();  //[X]Pull
            string line2 = File.ReadLines(FilePath).Skip(1).Take(1).First();  //[Y]Pull
            string line3 = File.ReadLines(FilePath).Skip(2).Take(1).First();  //Cooldown
            string line4 = File.ReadLines(FilePath).Skip(3).Take(1).First();  //Ingame sens [X]
            string line5 = File.ReadLines(FilePath).Skip(4).Take(1).First();  //Ingame sens [Y]
            string line6 = File.ReadLines(FilePath).Skip(5).Take(1).First();  //mode
            string line7 = File.ReadLines(FilePath).Skip(6).Take(1).First();  //default
            string line8 = File.ReadLines(FilePath).Skip(7).Take(1).First();  //1x
            string line9 = File.ReadLines(FilePath).Skip(8).Take(1).First();  //1.5x
            string line10 = File.ReadLines(FilePath).Skip(9).Take(1).First(); //2x
            string line11 = File.ReadLines(FilePath).Skip(10).Take(1).First(); //2.5x
            string line12 = File.ReadLines(FilePath).Skip(11).Take(1).First(); //3x
            string line13 = File.ReadLines(FilePath).Skip(12).Take(1).First(); //4x
            string line14 = File.ReadLines(FilePath).Skip(13).Take(1).First(); //5x
            string line15 = File.ReadLines(FilePath).Skip(14).Take(1).First(); //12x
            string line16 = File.ReadLines(FilePath).Skip(15).Take(1).First(); //Delay

            //Load values
            numericUpDown3.Value = Convert.ToInt32(line1); //[X]Pull
            numericUpDown1.Value = Convert.ToInt32(line2); //[Y]Pull
            numericUpDown2.Value = Convert.ToInt32(line3); //Cooldown
            Xsenstrackbar.Value = Convert.ToInt32(line4);  //Ingame sens [X]
            Ysenstrackbar.Value = Convert.ToInt32(line5);  //Ingame sens [Y]
            if (line6 == "Default")                        //mode
            {
                //Sets every value to default value
                metroSetComboBox18.Text = "Default";
                metroSetTrackBar9.Value = Convert.ToInt32(line7); //default
                metroSetTrackBar1.Value = Convert.ToInt32(line7);  //1x
                metroSetTrackBar2.Value = Convert.ToInt32(line7);  //1.5x
                metroSetTrackBar3.Value = Convert.ToInt32(line7); //2x
                metroSetTrackBar4.Value = Convert.ToInt32(line7); //2.5x
                metroSetTrackBar5.Value = Convert.ToInt32(line7); //3x
                metroSetTrackBar6.Value = Convert.ToInt32(line7); //4x
                metroSetTrackBar7.Value = Convert.ToInt32(line7); //5x
                metroSetTrackBar8.Value = Convert.ToInt32(line7); //12x
            }
            else
            {
                metroSetComboBox18.Text = "Advanced";
                metroSetTrackBar1.Value = Convert.ToInt32(line8);  //1x
                metroSetTrackBar2.Value = Convert.ToInt32(line9);  //1.5x
                metroSetTrackBar3.Value = Convert.ToInt32(line10); //2x
                metroSetTrackBar4.Value = Convert.ToInt32(line11); //2.5x
                metroSetTrackBar5.Value = Convert.ToInt32(line12); //3x
                metroSetTrackBar6.Value = Convert.ToInt32(line13); //4x
                metroSetTrackBar7.Value = Convert.ToInt32(line14); //5x
                metroSetTrackBar8.Value = Convert.ToInt32(line15); //12x
            }
            numericUpDown4.Value = Convert.ToInt32(line16);
        }
        #endregion **Preset Reader**

        #region **Scope Multiplier**
        private void metroSetComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroSetComboBox18.Text == "Default")
            {
                Disabler(true);
            }
            else
            {
                Disabler(false);
            }
        }

        private void Disabler(bool disable)
        {
            if(disable == true)
            {
                metroSetTrackBar1.Enabled = false;
                metroSetTrackBar2.Enabled = false;
                metroSetTrackBar3.Enabled = false;
                metroSetTrackBar4.Enabled = false;
                metroSetTrackBar5.Enabled = false;
                metroSetTrackBar6.Enabled = false;
                metroSetTrackBar7.Enabled = false;
                metroSetTrackBar8.Enabled = false;
                metroSetTrackBar9.Enabled = true;
            }
            else
            {
                metroSetTrackBar1.Enabled = true;
                metroSetTrackBar2.Enabled = true;
                metroSetTrackBar3.Enabled = true;
                metroSetTrackBar4.Enabled = true;
                metroSetTrackBar5.Enabled = true;
                metroSetTrackBar6.Enabled = true;
                metroSetTrackBar7.Enabled = true;
                metroSetTrackBar8.Enabled = true;
                metroSetTrackBar9.Enabled = false;
            }
        }

        private void metroSetTrackBar9_Scroll(object sender)
        {
            int i = metroSetTrackBar9.Value;
            metroSetLabel30.Text = i.ToString();

            metroSetTrackBar1.Value = metroSetTrackBar9.Value;
            metroSetTrackBar2.Value = metroSetTrackBar9.Value;
            metroSetTrackBar3.Value = metroSetTrackBar9.Value;
            metroSetTrackBar4.Value = metroSetTrackBar9.Value;
            metroSetTrackBar5.Value = metroSetTrackBar9.Value;
            metroSetTrackBar6.Value = metroSetTrackBar9.Value;
            metroSetTrackBar7.Value = metroSetTrackBar9.Value;
            metroSetTrackBar8.Value = metroSetTrackBar9.Value;
            Refresh();
        }

        private void metroSetTrackBar1_Scroll(object sender)
        {
            int i = metroSetTrackBar1.Value;
            metroSetLabel13.Text = i.ToString();
        }

        private void metroSetTrackBar2_Scroll(object sender)
        {
            int i = metroSetTrackBar2.Value;
            metroSetLabel16.Text = i.ToString();
        }

        private void metroSetTrackBar3_Scroll(object sender)
        {
            int i = metroSetTrackBar3.Value;
            metroSetLabel18.Text = i.ToString();
        }

        private void metroSetTrackBar4_Scroll(object sender)
        {
            int i = metroSetTrackBar4.Value;
            metroSetLabel20.Text = i.ToString();
        }

        private void metroSetTrackBar5_Scroll(object sender)
        {
            int i = metroSetTrackBar5.Value;
            metroSetLabel22.Text = i.ToString();
        }

        private void metroSetTrackBar6_Scroll(object sender)
        {
            int i = metroSetTrackBar6.Value;
            metroSetLabel24.Text = i.ToString();
        }

        private void metroSetTrackBar7_Scroll(object sender)
        {
            int i = metroSetTrackBar7.Value;
            metroSetLabel26.Text = i.ToString();
        }

        private void metroSetTrackBar8_Scroll(object sender)
        {
            int i = metroSetTrackBar8.Value;
            metroSetLabel28.Text = i.ToString();
        }
        #endregion **Scope Multiplier**

        #region **Bind preset to hk generator**
        private void metroSetDefaultButton2_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox22.Text == "")
            {
                MessageBox.Show("Please select a preset hotkey", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (metroSetComboBox11.Text == "" || metroSetComboBox12.Text == "" || metroSetComboBox13.Text == "" || metroSetComboBox14.Text == "" || metroSetComboBox19.Text == "" || metroSetComboBox20.Text == "" || metroSetComboBox21.Text == "")
                {
                    MessageBox.Show("Please select a preset", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Create File & write Settings
                    File.AppendAllText(@"C:\7Scripts\Light\binds\" + metroSetComboBox22.Text + ".ini", metroSetComboBox11.Text + "\n");
                    File.AppendAllText(@"C:\7Scripts\Light\binds\" + metroSetComboBox22.Text + ".ini", metroSetComboBox12.Text + "\n");
                    File.AppendAllText(@"C:\7Scripts\Light\binds\" + metroSetComboBox22.Text + ".ini", metroSetComboBox13.Text + "\n");
                    File.AppendAllText(@"C:\7Scripts\Light\binds\" + metroSetComboBox22.Text + ".ini", metroSetComboBox14.Text + "\n");
                    File.AppendAllText(@"C:\7Scripts\Light\binds\" + metroSetComboBox22.Text + ".ini", metroSetComboBox19.Text + "\n");
                    File.AppendAllText(@"C:\7Scripts\Light\binds\" + metroSetComboBox22.Text + ".ini", metroSetComboBox20.Text + "\n");
                    File.AppendAllText(@"C:\7Scripts\Light\binds\" + metroSetComboBox22.Text + ".ini", metroSetComboBox21.Text + "\n");
                    File.AppendAllText(@"C:\7Scripts\Light\binds\" + metroSetComboBox22.Text + ".ini", @"C:\7Scripts\Light\presets\" + metroSetComboBox11.Text + @"\" + metroSetComboBox12.Text + @"\" + metroSetComboBox13.Text + @"\" + metroSetComboBox14.Text + @"\" + metroSetComboBox19.Text + @"\" + metroSetComboBox20.Text + @"\" + metroSetComboBox21.Text + @"\Preset.ini" + "\n");

                    CheckBinds();
                }
            }
        }
        #endregion **Bind preset to hk generator**

        #region **Delete**
        private void metroSetDefaultButton4_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox7.Enabled == true)
            {
                File.Delete(@"C:\7Scripts\Light\binds\Preset1.ini");
            }
            CheckBinds();
        }

        private void metroSetDefaultButton5_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox8.Enabled == true)
            {
                File.Delete(@"C:\7Scripts\Light\binds\Preset2.ini");
            }
            CheckBinds();
        }

        private void metroSetDefaultButton6_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox9.Enabled == true)
            {
                File.Delete(@"C:\7Scripts\Light\binds\Preset3.ini");
            }
            CheckBinds();
        }

        private void metroSetDefaultButton7_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox10.Enabled == true)
            {
                File.Delete(@"C:\7Scripts\Light\binds\Preset4.ini");
            }
            CheckBinds();
        }

        private void metroSetDefaultButton10_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox40.Enabled == true)
            {
                File.Delete(@"C:\7Scripts\Light\binds\Preset5.ini");
            }
            CheckBinds();
        }

        private void metroSetDefaultButton11_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox41.Enabled == true)
            {
                File.Delete(@"C:\7Scripts\Light\binds\Preset6.ini");
            }
            CheckBinds();
        }

        private void metroSetDefaultButton12_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox42.Enabled == true)
            {
                File.Delete(@"C:\7Scripts\Light\binds\Preset7.ini");
            }
            CheckBinds();
        }

        private void metroSetDefaultButton9_Click(object sender, EventArgs e)
        {
            if (metroSetComboBox43.Enabled == true)
            {
                File.Delete(@"C:\7Scripts\Light\binds\Preset8.ini");
            }
            CheckBinds();
        }
        #endregion **Delete**

        #region **Save misc**
        private void metroSetDefaultButton8_Click(object sender, EventArgs e)
        {
            FileManagement.WriteSettings("GrenadeKey", metroSetComboBox28.Text, "Misc");
            FileManagement.WriteSettings("AutoGrenadeHotkey", metroSetComboBox27.Text, "Misc");
            FileManagement.WriteSettings("Timing", Convert.ToString(numericUpDown5.Value), "Misc");
            FileManagement.WriteSettings("AutoLeanLeft", metroSetComboBox29.Text, "Misc");
            FileManagement.WriteSettings("AutoLeanRight", metroSetComboBox30.Text, "Misc");
            FileManagement.WriteSettings("AutoLeanDUC", Convert.ToString(numericUpDown6.Value), "Misc");
            FileManagement.WriteSettings("AutoLeanC", Convert.ToString(numericUpDown7.Value), "Misc");
            FileManagement.WriteSettings("AutoLeanM", metroSetComboBox31.Text, "Misc");
            FileManagement.WriteSettings("FastPeekLeft", metroSetComboBox34.Text, "Misc");
            FileManagement.WriteSettings("FastPeekRight", metroSetComboBox33.Text, "Misc");
            FileManagement.WriteSettings("FastPeekDUC", Convert.ToString(numericUpDown9.Value), "Misc");
            FileManagement.WriteSettings("FastPeekC", Convert.ToString(numericUpDown8.Value), "Misc");
            FileManagement.WriteSettings("FastPeekM", metroSetComboBox32.Text, "Misc");
            FileManagement.WriteSettings("StrafeLeft", metroSetComboBox37.Text, "Misc");
            FileManagement.WriteSettings("StrafeRight", metroSetComboBox36.Text, "Misc");
            FileManagement.WriteSettings("StrafeDUC", Convert.ToString(numericUpDown11.Value), "Misc");
            FileManagement.WriteSettings("StrafeC", Convert.ToString(numericUpDown10.Value), "Misc");
            FileManagement.WriteSettings("StrafeM", metroSetComboBox35.Text, "Misc");
            FileManagement.WriteSettings("StartLeftHotkey", metroSetComboBox38.Text, "Misc");
            FileManagement.WriteSettings("StartRightHotkey", metroSetComboBox39.Text, "Misc");

            MessageBox.Show("Settings saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion **Save misc**

    }
}