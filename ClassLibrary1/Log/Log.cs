using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilityLib.Log
{
    public class Log
    {
        public string FilePath = Application.StartupPath +"\\"+DateTime.Now.ToString()+".txt";
        StreamWriter writer;

        public void LogInfo(string msg)
        {
            writer = new StreamWriter(FilePath);
            if (!File.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            else
            {
                writer.WriteLine(string.Format("LogInfo--> {0} {1}"), DateTime.Now.ToString(), msg);
            }
        }

        public void LogErr(string msg)
        {
            writer = new StreamWriter(FilePath);
            if (!File.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            else
            {
                writer.WriteLine(string.Format("LogErr--> {0} {1}"), DateTime.Now.ToString(), msg);
            }

        }
        public void WarnLog(string msg)
        {
            writer = new StreamWriter(FilePath);
            if (!File.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            else
            {
                writer.WriteLine(string.Format("LogWarn--> {0} {1}"), DateTime.Now.ToString(), msg);
            }

        }
    }
}
