using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UtilityLib.Log;
using UtilityLib.Util;

namespace UtilityLib.Can
{
    internal class clsElecProcess
    {

        /* Inspection Step Def */
        //IMS 및 일반 검사 
        internal TEST_CODE TEST_MAIN;
        internal ERROR_CODE ERROR_MAIN;

        internal TEST_CODE TEST_MOTOR;
        internal ERROR_CODE ERROR_MOTOR;

        internal TEST_CODE TEST_HEAT_VENT; //HEAT VENT
        internal ERROR_CODE ERROR_HEAT_VENT;

        internal TEST_CODE TEST_DELIVERY_POS;
        internal ERROR_CODE ERROR_DELIVERY_POS;

        private Thread thrInit;
        private Thread thrMotor;
        private Thread thrHV;
        private Thread thrDP;
        internal Log.Log Log;

        internal enum TEST_CODE
        
        {
  
            IDLE,                   //초기화 상태                        
            READY,                  //검사시작 신호가 들어간 상태
            START,                  //검사시작 
            DONECHECK,              //검사완료 체크

            /* LIMIT */
            LimitClear,             //리미트 클리어
            LimitSetting,           //리미트 세팅

            /* INIT POS */
            INIT_POS_READY,         //초기위치 준비
            INIT_POS,               //초기위치 이동
            INIT_POS_DONE,          //초기위치 이동 완료


            /* MOTOR */
            SlideF,                 //슬라이드 전진                      
            SlideB,                 //슬라이드 후진                      
            HeightU,                //하이트 상승                        
            HeightD,                //하이트 하강                       
            TiltU,                  //틸트 상승                          
            TiltD,                  //틸트 하강
            RELAXF,                 //릴렉스 전진
            RELAXB,                 //릴렉스 후진

            LimitCheck,             //리미트 체크

            /* Heat Vent */
            HEAT_HIGH,
            HEAT_MID,
            HEAT_LOW,
            HEAT_OFF,

            VENT_HIGH,
            VENT_MID,
            VENT_LOW,
            VENT_OFF,

            FAN_ON,
            FAN_OFF,

            REAR_HEAT_HIGH,
            REAR_HEAT_MID,
            REAR_HEAT_LOW,
            REAR_HEAT_OFF,

            /* DELIVERY POS */
            DP_READY,                //납품위치 준비
            DP_MOVE,                 //납품위치 이동
            DP_DONE,                 //납품위치 완료

            DP_CHECK_READY,          //납품위치 확인 준비
            DP_CHECK,                //납품위치 확인 


            JUDGE,                   //판정
            DONE,                    //종료
            ERROR,                   //동작 오류
        };
        internal enum ERROR_CODE
        {
            NONE,                      // 초기
            //INIT
            INIT_MOVE_FAILED,          // 초기위치 미동작
            INIT_MOTOR_NOT_DEFINE,     // 초기위치 모터 미정의 
            WEIGHT_NOT_MOVE,           // 웨이트 동작 없음

            //LIMIT                    
            LIMIT_CLEAR_NOT_RESPONSE,   // 리미트 클리어 응답없음
            LIMIT_SET_NOT_RESPONSE,     // 리미트 세팅 응답없음
            LIMIT_CHECK_NOT_RESPONSE,   // 리미트 체크 응답없음

            //MOTOR
            MOTOR_MOVE_FAILED,         // 모터 미동작
            MOTOR_NOT_DEFINE,          // 모터 미정의

            //HEAT VENT
            HEAT_VENT_TIME_OUT,        // 동작시간 초과
            HEAT_VENT_POWER_ON_FAIL,   // POWER ON 실패 

            //DELIVERY POSITION
            DP_CYLINDER_NOT_MOVE,      //실린더 동작 안함
        }

        public void InitThread()
        {
            try
            {
                if (thrInit != null)
                    thrInit.Abort();
                thrInit = new Thread(MainProcecss);
                thrInit.Name = "INIT PROCESS THREAD";
                thrInit.IsBackground = true;
                thrInit.Priority = ThreadPriority.Highest;
                thrInit.Start();

                if (thrMotor != null)
                    thrMotor.Abort();
                thrMotor = new Thread(MotorInspection);
                thrMotor.Name = "INIT PROCESS Thread";
                thrMotor.IsBackground = true;
                thrMotor.Priority = ThreadPriority.Highest;
                thrMotor.Start();

                if (thrHV != null)
                    thrHV.Abort();
                thrHV = new Thread(HVInspection);
                thrHV.Name = "HV Inspection Thread";
                thrHV.IsBackground = true;
                thrHV.Priority = ThreadPriority.Highest;
                thrHV.Start();


                if (thrDP != null)
                    thrDP.Abort();
                thrDP = new Thread(DPInspection);
                thrDP.Name = "Delivery Pos Move Thread";
                thrHV.Priority = ThreadPriority.Highest;
                thrHV.Start();

            }
            catch (Exception e)
            {
              Log.LogInfo("[ERROR]" + MethodBase.GetCurrentMethod().Name + ":" + e.Message);
            }
       
        }
        public void DPInspection()
        {
            TEST_CODE BEFORE_STEP = TEST_CODE.READY;
            TEST_CODE TMP_STEP = TEST_CODE.READY;

            double AD = 0;

      //     clsModel.
        }
        public void MainProcecss()
        {

        }
        public void MotorInspection()
        {

        }
        public void HVInspection()
        {

        }





    }
}
