using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
namespace UtilityLib
{
    partial class Equal<TFirst,TSecond> :IEquatable<string> where TFirst : class
    {
        
        public bool Equals(string Model)
        {
            return false;
        }


        //전압을 비교해서 전압이 높을떄 OK 아니면 NG 뜨게 하기
        public void EqualVoltage(double first, double Second,System.Windows.Forms.Label Judge)
        {
         if(first < Second) {
                Judge.Text = "OK";
                Judge.BackColor = Color.White;
                Judge.ForeColor = Color.DarkGreen;
            }
            else {
                Judge.Text = "NG";
                Judge.ForeColor = Color.White;
                Judge.BackColor = Color.DarkRed;
            }
        }


    }
}
