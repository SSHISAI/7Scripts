using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace _7Scripts
{
    class FileManagement
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public FileManagement(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }

        #region **Detect sens**
        public static string ReadIngameSettings(string name, string category, string path)
        {
            var MyIni = new FileManagement(path);
            var read = MyIni.Read(name, category);
            return read;
        }
        #endregion **Detect sens**

        #region **Settings**
        public static void WriteSettings(string name, string value, string category)
        {
            var MyIni = new FileManagement(@"C:\7Scripts\Light\Settings.ini");
            MyIni.Write(name, value, category);
        }

        public static string ReadSettings(string name, string category)
        {
            var MyIni = new FileManagement(@"C:\7Scripts\Light\Settings.ini");
            var read = MyIni.Read(name, category);
            return read;
        }

        public static void DeleteSettingsKey(string name, string category)
        {
            var MyIni = new FileManagement(@"C:\7Scripts\Light\Settings.ini");
            MyIni.DeleteKey(name, category);
        }

        public static bool CheckSettingsKey(string name, string category)
        {
            var MyIni = new FileManagement(@"C:\7Scripts\Light\Settings.ini");
            if (MyIni.KeyExists("DefaultVolume", "Audio"))
            {
                return true;
            }
            return false;
        }
        #endregion **Settings**
    }
}
