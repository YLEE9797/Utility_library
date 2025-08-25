using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UtilityLib.Plc;
using UtilityLib.Util;

namespace UtilityLib.Inspection.SensorInspection
{
    public class HeaterVentOnOFFControl
    {
        //HEAT/VENT ON/OFF
        //아니 그니까 Device 타입에 따라서 달라지는거지 ->PLC 를 선택했다 그러면 PLC 에 써지는거고 Crevis 에 선택했다 그러면
        //Crevis 에 써지는 거임
        public clsModel.eHeatVent HeatVentType;
        public clsPlc Plc;
         public HeaterVentOnOFFControl(clsModel.eHeatVent HV,clsPlc plc)
        {
            this.HeatVentType = HV;
            this.Plc = plc;
        }

     
        public enum HeaterVent
        {
         Heat_H1,
         Heat_H2,
         Heat_H3,

         Veat_H1,
         Veat_H2,
         Veat_H3,
         OFF
        }

        //H/V_파워 키는거
        public void HV_POWER_ON(int Channel,byte write)
        {

        }
        //H/V_파워 끄는거
        public void HV_POWER_OFF(int Channel, byte write)
        {

        }












    }
}
