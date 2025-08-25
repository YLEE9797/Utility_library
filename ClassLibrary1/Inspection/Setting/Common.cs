using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib.Log;

namespace UtilityLib.Inspection.Setting
{
    public class Common
    {

        public Log.Log Log;
        public double Height_Distance;
        public double Slide_Distance;
        public double Tilt_Distance;
        public double Relax_Distance;
        public bool TEST_START;
        [DllImport("kernel32")]
        extern static public int GetPrivateProfileString
        (
            string lpApplicationName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            int nSize,
            string lpFileName
        );
        [DllImport("kernel32")]
        extern static public int WritePrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string ipString,
            string lpFileName
            );
        public string sysINIRead(string section, string item, string defaultValue = "")
        {
            StringBuilder buffer = new StringBuilder(255);
            int bufLen;

            try
            {
                if (!File.Exists(Application.StartupPath + @"\Setup\" + @"\WORK.ini"))
                    File.WriteAllText(Application.StartupPath + @"\Setup\" + @"\WORK.ini", string.Empty);

                bufLen = GetPrivateProfileString(section, item, defaultValue, buffer, 255, Application.StartupPath + @"\Setup\" + @"\WORK.ini");
            }
            catch (Exception e)
            {
                Log.LogErr("시스템 설정파일 읽기 실패 " + "(WORK.ini)");
                return e.Message;
            }

            return buffer.ToString();
        }
        public void sysINIwrite(string section, string item, string value)
        {
            try
            {
                WritePrivateProfileString(section, item, value, Application.StartupPath + @"\Setup\" + @"\WORK.ini");
            }
            catch (Exception)
            {
                Log.LogErr("시스템 설정파일 쓰기 실패 " + "(WORK.ini)");
                return;
            }
        }
        public string sysINISpecRead(string section, string item, string defaultValue = "")
        {
            StringBuilder buffer = new StringBuilder(255);
            int bufLen;

            try
            {
                if (!File.Exists(Application.StartupPath + @"\Setup\" + @"\Setup.ini"))
                    File.WriteAllText(Application.StartupPath + @"\Setup\" + @"\Setup.ini", string.Empty);

                bufLen = GetPrivateProfileString(section, item, defaultValue, buffer, 255, Application.StartupPath + @"\Setup\" + @"\Setup.ini");
            }
            catch (Exception e)
            {
                Log.LogErr("스펙 설정파일 읽기 실패 " + "(Setup.ini)");
                return e.Message;
            }

            return buffer.ToString();
        }
        public void sysINISpecWrite(string section, string item, string value)
        {
            try
            {
                WritePrivateProfileString(section, item, value, Application.StartupPath + @"\Setup\" + @"\Setup.ini");
            }
            catch (Exception)
            {
                Log.LogErr("스펙 설정파일 읽기 실패 " + "(Setup.ini)");
                return;
            }
        }

        public  void sysINIEleSpecWrite(string section, string item, string value)
        {
            try
            {
                WritePrivateProfileString(section, item, value, Application.StartupPath + @"\Setup\" + @"\EleSetup.ini");
            }
            catch (Exception)
            {
                Log.LogErr("스펙 설정파일 쓰기 실패 " + "(EleSetup.ini)");
                return;
            }
        }

        public string sysINIEleSpecRead(string section, string item, string defaultValue = "")
        {
            StringBuilder buffer = new StringBuilder(255);
            int bufLen;

            try
            {
                if (!File.Exists(Application.StartupPath + @"\Setup\" + @"\EleSetup.ini"))
                    File.WriteAllText(Application.StartupPath + @"\Setup\" + @"\EleSetup.ini", string.Empty);

                bufLen = GetPrivateProfileString(section, item, defaultValue, buffer, 255, Application.StartupPath + @"\Setup\" + @"\EleSetup.ini");
            }
            catch (Exception e)
            {
                Log.LogErr("스펙 설정파일 읽기 실패 " + "(EleSetup.ini)");
                return e.Message;
            }

            //return buffer.Substring(0, bufLen);
            return buffer.ToString();
        }
        public void GetDistance()
        {
            Height_Distance = Convert.ToDouble(sysINISpecRead("Spec", "Height_Distance", "1.41"));
            Slide_Distance = Convert.ToDouble(sysINISpecRead("Spec", "Slide_Distance", "1.41"));
            Tilt_Distance = Convert.ToDouble(sysINISpecRead("Spec", "Tilt_Distance", "1.41"));
            Relax_Distance = Convert.ToDouble(sysINISpecRead("Spec", "Tilt_Distance", "1.41"));
        }

        internal void sysINISpecWrite(string car, string v, object value)
        {
            throw new NotImplementedException();
        }
    }
}
