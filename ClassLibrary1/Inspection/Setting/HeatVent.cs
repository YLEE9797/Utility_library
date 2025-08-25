using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib.Log;

namespace UtilityLib.Inspection.Setting
{
    internal class HeatVent
    {
        public Common common;
        public Log.Log Log;

        //HV_MAIN 전류
        public double HV_Main;
        //HV 포지션
        public string Posit;
        //HEAT_HIGH_MIN
        public double HEAT_HIGH_MIN;
        //HEAT_OFF_MIN
        public double HEAT_OFF_MIN;
        //HEAT_HIGH_MAX
        public double HEAT_HIGH_MAX;
        //HEAT_LOW_TIME
        public double HEAT_LOW_TIME;
        //HEAT_OFF_MAX
        public double HEAT_OFF_MAX;
        //HEAT_HIGH_TIME
        public double HEAT_HIGH_TIME;
        //HEAT_MID_TIME
        public double HEAT_MID_TIME;
        //HEAT_OFF_TIME
        private object HEAT_OFF_TIME;
        //HEAT_OFFSET_TIME
        public double HEAT_OFFSET_TIME;
        //HEAT_SPAN_TIME
        public double HEAT_SPAN_TIME;

        public double VENT_HIGH_MIN;
        public double VENT_OFF_MIN;
        public double VENT_HIGH_MAX;
        public double VENT_OFF_MAX;
        public double VENT_HIGH_TIME;
        public double VENT_MID_TIME;
        public double VENT_LOW_TIME;
        public double VENT_OFF_TIME;
        public double VENT_OFFSET_TIME;
        public double VENT_SPAN_TIME; 

        //히터/벤트_스펙 불러오기
        public void GetHeatVentSpec(string Car, ComboBox cbPosition)
        {
            try
            {
                Posit = cbPosition.Text.Replace(" ", "_");
                HEAT_HIGH_MIN = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_HIGH_MIN", "1.2"));
                //HEAT_OFF_MIN
                HEAT_OFF_MIN=Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_OFF_MIN", "0.5"));
                //HEAT_HIGH_MAX
                HEAT_HIGH_MAX = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_HIGH_MAX", "0.2"));

                HEAT_OFF_MAX = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit+ "HEAT_OFF_MAX", "0.1"));

                HEAT_HIGH_TIME = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_HIGH_TIME","0.2"));

                HEAT_MID_TIME = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_MID_TIME", "0.2"));

                HEAT_LOW_TIME = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_LOW_TIME", "0.1"));

                HEAT_OFF_TIME = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_OFF_TIME", "0.1"));

                HEAT_OFFSET_TIME = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_OFFSET_TIME", "0.0"));

                HEAT_SPAN_TIME=Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_SPAN_TIME", "0.1"));

                //HEAT_HIGH_MIN
                HEAT_HIGH_MIN = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_HIGH_MIN", "0.1"));
                //HEAT_OFF_MIN
                HEAT_OFF_MIN = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_HEAT_OFF_MIN","0.1"));

                //VENT_OFF_MIN
                VENT_OFF_MIN = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_VENT_OFF_MIN","0.1"));
                //VENT_HIGH_MAX
                VENT_HIGH_MAX =Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_VENT_HIGH_MAX","0.2"));

                VENT_OFF_MAX = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_VENT_OFF_MAX", "0.2"));

                VENT_HIGH_TIME = Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_VENT_HIGH_TIME", "0.3"));
             
                //VENT_MID_TIME
                VENT_MID_TIME=Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_VENT_MID_TIME", "0.2"));
                //VENT_LOW_TIME
                VENT_LOW_TIME=Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_VENT_LOW_TIME","0.1"));
                //VENT_OFF_TIME
                VENT_OFF_TIME=Convert.ToDouble(common.sysINIEleSpecRead(Car, Posit + "_VENT_OFF_TIME","0.1"));
                //VENT_OFFSET
                VENT_OFFSET_TIME=Convert.ToDouble(common.sysINISpecRead(Car, Posit + "_VENT_OFFSET_TIME", "0.1"));
                //VENT_SPAN
                VENT_SPAN_TIME=Convert.ToDouble(common.sysINISpecRead(Car, Posit + "_VENT_SPAN_TIME", "0.1"));
            }
            catch(Exception e)
            {

            }
        }

        //히터/벤트_스펙 저장
        public void SetHeatVentSpec(string Car,ComboBox cbPosition)
        {
            try
            {

                common.sysINISpecWrite("SYSTEM", "HV_MAIN", HV_Main.ToString());
                Posit = cbPosition.Text.Replace(" ", "_");


                //HEAT_HIGH_MIN
                common.sysINISpecWrite(Car, Posit + "_HEAT_HIGH_MIN", HEAT_HIGH_MIN.ToString());
                //HEAT_OFF_MIN
                common.sysINISpecWrite(Car, Posit + "_HEAT_OFF_MIN", HEAT_OFF_MIN.ToString());
                //HEAT_HIGH_MAX
                common.sysINISpecWrite(Car, Posit + "_HEAT_HIGH_MAX", HEAT_HIGH_MAX.ToString());
                //HEAT_OFF_MAX
                common.sysINISpecWrite(Car, Posit + "_HEAT_OFF_MAX", HEAT_OFF_MAX.ToString());
                //HEAT_HIGH_TIME 
                common.sysINISpecWrite(Car, Posit + "_HEAT_HIGH_TIME", HEAT_HIGH_TIME.ToString());
                //HEAT_MID_TIME
                common.sysINISpecWrite(Car, Posit + "_HEAT_MID_TIME", HEAT_MID_TIME.ToString());
                //HEAT_LOW_TIME
                common.sysINISpecWrite(Car, Posit + "_HEAT_LOW_TIME", HEAT_LOW_TIME.ToString());
                //HEAT_OFF_TIME
                common.sysINISpecWrite(Car, Posit + "_HEAT_OFF_TIME", HEAT_OFF_TIME.ToString());
                //HEAT_OFFSET
                common.sysINISpecWrite(Car, Posit + "_HEAT_OFFSET_TIME", HEAT_OFFSET_TIME.ToString());
                //HEAT_SPAN
                common.sysINISpecWrite(Car, Posit + "_HEAT_SPAN_TIME", HEAT_SPAN_TIME.ToString());



                //HEAT_HIGH_MIN
                common.sysINIEleSpecWrite(Car, Posit + "_HEAT_HIGH_MIN", VENT_HIGH_MIN.ToString());
                //HEAT_OFF_MIN
                common.sysINISpecWrite(Car, Posit + "_HEAT_OFF_MIN", VENT_OFF_MIN.ToString());
                //HEAT_HIGH_MAX
                common.sysINISpecWrite(Car, Posit + "_VENT_HIGH_MAX", VENT_HIGH_MAX.ToString());
                //HEAT_OFF_MAX
                common.sysINISpecWrite(Car, Posit + "_VENT_OFF_MAX", VENT_OFF_MAX.ToString());
                //HEAT_HIGH_TIME 
                common.sysINISpecWrite(Car, Posit + "_VENT_HIGH_TIME", VENT_HIGH_TIME.ToString());
                //HEAT_MID_TIME
                common.sysINISpecWrite(Car, Posit + "_VENT_MID_TIME", VENT_MID_TIME.ToString());
                //HEAT_LOW_TIME
                common.sysINISpecWrite(Car, Posit + "_VENT_LOW_TIME", VENT_LOW_TIME.ToString());
                //HEAT_OFF_TIME
                common.sysINISpecWrite(Car, Posit + "_VENT_OFF_TIME", VENT_OFF_TIME.ToString());
                //HEAT_OFFSET
                common.sysINISpecWrite(Car, Posit + "_VENT_OFFSET_TIME", VENT_OFFSET_TIME.ToString());
                //HEAT_SPAN
                common.sysINISpecWrite(Car, Posit + "_VENT_SPAN_TIME", VENT_SPAN_TIME.ToString());
                Log.LogInfo("저장 성공");
            }
            catch (Exception ee)
            {
                Log.LogErr("저장 실패"+ee.Message);
            }
        }
        





    }
}
