using MathNet.Numerics;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib.Inspection.Setting;
using UtilityLib.Util;

namespace UtilityLib.Inspection.SensorInspection
{
    internal class SeatPositionSensor
    {
        #region TypeDef
        double AD;//AD값
        string Judge = string.Empty;//판정
        bool DistanceCheck = false;//거리값체크(bool)
        public Motor Motor;
        public Common common;
        public bool Slide_Distance_Check =false;
        public bool Height_Distance_Check = false;
        public bool Tilt_Distance_Check = false;
        public bool Relax_Distance_Check = false;
        #endregion

        #region FUNC
        //거리값
        //슬라이드,하이트,틸트,릴렉스,레그,익스텐션에 대한 좌석 위치 거리 정보를 나타낸다
        //일반공식 ->mm,cm
        //측정거리 범위 -> 0-5m
        //AD ->거리(미터 공식)
        public double GetPositionStateValue(Motor.MotorItem MotorItem, double Value)
        {
            //Slide
            if (Motor.MotorItem.SLIDE == MotorItem)
            {
                AD = Value / 10.0 * 100.0 * (double)Motor.Span + (double)Motor.Offset;
            }
            //NONE
            else if (Motor.MotorItem.None == MotorItem)
            {
                AD = 0.0;
                return AD;
            }
            //Height
            else if (Motor.MotorItem.HEIGHT == MotorItem)
            {

                AD = Value / 10.0 * 100.0 * (double)Motor.Span + (double)Motor.Offset;
            }
            //Tilt
            else if (Motor.MotorItem.TILT == MotorItem)
            {
                AD = Value / 10.0 * 100.0 * (double)Motor.Span + (double)Motor.Offset;
            }
            //Relax
            else if (Motor.MotorItem.RELAX == MotorItem)
            {

                AD = Value / 10.0 * 100.0 * (double)Motor.Span + (double)Motor.Offset;
            }
            //LUMB
            else if (Motor.MotorItem.LUMB == MotorItem)
            {

                AD = Value / 10.0 * 100.0 * (double)Motor.Span + (double)Motor.Offset;
            }
            //LUMB
            else if (Motor.MotorItem.LEG_EXT == MotorItem)
            {

                AD = Value / 10.0 * 100.0 * (double)Motor.Span + (double)Motor.Offset;
            }

            return AD;
        }
        //원하고자 하는 범위가 맞는지 체크하여 들어오면 OK,벗어나면 NG,아니면 NOT DISTANCE
        public string Distance_RangeCheck(double DistRange, double Value)
        {
            if (0 > DistRange) { return "Distance Value is Minus"; }
            if (0 < DistRange)
            {
                DistanceCheck = DistRange.AlmostEqual(Value, DistRange);
                if (DistanceCheck)
                    Judge = "OK";
                else
                    Judge = "NG";
            }
            else
                return "NOT Distance Range";
            return Judge;
        }
        //납품위치 거리만큼 갔을떄 납품위치 체크(bool 변수)
        /// <summary>
        /// 모터 타입별로 거리값 체크 해서 그 거리값과 설정 거리값이 비슷한지
        /// 안비슷한지를 체크
        /// 만약 안비슷하다면 false 같다면 true
        /// </summary>
        /// <param name="Distance">거리값</param>
        /// <param name="Type">사양(IMS,POWER)</param>
        /// <param name="MotorType">모터 타입</param>
        public void CheckInitPos(double Distance, clsModel.eType Type,clsModel.eMotorType MotorType)
        {
            common.GetDistance();
            //POWER 사양이나 IMS 사양일떄
            if (Type == clsModel.eType._IMS|| Type == clsModel.eType._POWER)
            {
                switch (MotorType)
                {
                    case clsModel.eMotorType.SLIDE:
                        if (common.Slide_Distance.AlmostEqual(Distance))
                        {
                            Slide_Distance_Check = true;
                        }
                        else { Slide_Distance_Check = false; }
                        break;
                    case clsModel.eMotorType.HEIGHT:
                        if (common.Height_Distance.AlmostEqual(Distance))
                        {
                            Height_Distance_Check = true;
                        }
                        else { Height_Distance_Check = false; }
                        break;
                    case clsModel.eMotorType.TILT:
                        if (common.Tilt_Distance.AlmostEqual(Distance))
                        {
                            Tilt_Distance_Check = true;
                        }
                        else { Tilt_Distance_Check = false; }
                        break;
                }   
            }
        }
        #endregion
    }
}
