using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    internal class Lamda
    {
        Func<int,string> ECU_RST => statusCode =>
        {
            switch (statusCode)
            {
                case 0: return "OK";
                case 1: return "NG";
                case 2: return "Unused";
                default: return "Unknown";
            }
        };

       public void ConvertIntToHex(int value)
        {

        }
    }
}
