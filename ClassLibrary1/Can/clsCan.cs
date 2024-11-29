using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib.Util;
using TPCANHandle = System.UInt16;
using TPCANTimestampFD = System.UInt64;

namespace UtilityLib.Can
{
    public class ClsCan
    {
        private delegate void ReadDelegateHandler();
        public delegate void dlgCanRead();
        public dlgCanRead CanRead;

        private Form _main;

        /* Thread */
        private Thread m_thread_Can;
        private Thread thrCanPeriod;
        private Thread thrLimitDelay;

        private Stopwatch Tick_50 = new Stopwatch();
        private Stopwatch Tick_100 = new Stopwatch();
        private Stopwatch Tick_200 = new Stopwatch();
        /* Can Info */
        internal string Channel;
        internal int Baudrate;

        internal Label lbState;
        internal Label lbSignal; //Blink
        //internal JControl.LogData.enCanType CanType = JControl.LogData.enCanType.NONE;


        private TPCANHandle m_PcanHandle;
        public static TPCANHandle[] m_HandlesArray;

        private TPCANBaudrate m_Baudrate;
        private TPCANType m_HwType;
        private TPCANMsg PeriodMsg = new TPCANMsg(); //삭제 대기

        public bool IsConnect
        {
            get
            {
                if (PCANBasic.GetStatus(m_PcanHandle) != TPCANStatus.PCAN_ERROR_ILLCLIENT &&
                    PCANBasic.GetStatus(m_PcanHandle) != TPCANStatus.PCAN_ERROR_INITIALIZE &&
                     PCANBasic.GetStatus(m_PcanHandle) != TPCANStatus.PCAN_ERROR_BUSOFF &&
                     PCANBasic.GetStatus(m_PcanHandle) != TPCANStatus.PCAN_ERROR_BUSPASSIVE)
                    return true;
                else
                    return false;
            }
        }

        /* LIMIT MODE */
        internal static bool LIMITCHECK_MODE;
        internal static bool LIMITCLEAR_MODE;
        internal static bool LIMITSET_MODE;
        /* Period Var */

        protected ushort[] CRCTbl { get; set; }
        protected ushort CRC16 { get; set; }
        private Int32 _CLU_AlvCnt1 = 0;
        private Int32 _DAU_AlvCnt1 = 0;

        private Int32 _DPSS_AlvCnt1 = 0;
        private Int32 _DPSS_AlvCnt2 = 0;
        private Int32 _DPSS_AlvCnt3 = 0;


        public Int32 _PSS_DRV_FD_AlvCnt1 = 0;
        public Int32 _PSS_AST_FD_AlvCnt1 = 0;

        private Int16 _IDforCrcCalculationDPSS_01_200ms = 0x467;
        private Int16 _IDforCrcCalculationDPSS_02_200ms = 0x468;
        private Int16 _IDforCrcCalculationDPSS_03_200ms = 0x469;
        private Int16 _IDforCRCcalculationCLU = 0x1AA;
        private Int16 _IDforCRCcalculationDAU = 0x402;

        /* SWITCH(LOCAL) CAN VAR */
        private const byte DEFAULT = 0x00;
        private const byte OFF = 0x01;
        private const byte ON = 0x02;
        private const byte INVALID = 0x03;



        /* Enum Set*/
        internal enum DianosticMotor
        {
            NONE,
            SLIDE_FWD,
            SLIDE_BWD,
            HEIGHT_UP,
            HEIGHT_DOWN,
            TILT_UP,
            TILT_DOWN,
        }
        internal enum eHVState
        {
            OFF = 0x02,
            V1 = 0x03,
            V2 = 0x04,
            V3 = 0x05,
            H1 = 0x06,
            H2 = 0x07,
            H3 = 0x08,
        }
        internal enum eEcuReadType
        {
            PARTNO,
            SW_VER,
            HW_VER,
            Distance,
        }

        /*- GN7 CAN VAR -*/
        //internal clsModel.eMotorType CurrentLimitSetMotor = clsModel.eMotorType.NONE;
        /* [IMS SETTING] */

        public Int32 _PWSW_AlvCnt = 0;//4Val
        /*[DPSU]*/
        //DIANOIST
        internal bool _DiagnoistMode_DPSU = false;
        internal bool _DiagnoistOnFlag_DPSU = false;
        internal bool _DiagnoistMoving_DPSU = false;

        internal static DianosticMotor _DPSU_DianoistMotor = DianosticMotor.NONE;
        //SW
        internal static bool _DPSU_Motor_SlideFwd;
        internal static bool _DPSU_Motor_SlideBwd;

        internal static bool _DPSU_Motor_HeightUp;
        internal static bool _DPSU_Motor_HeightDown;

        internal static bool _DPSU_Motor_TiltUp;
        internal static bool _DPSU_Motor_TiltDown;

        internal static bool _DPSU_Motor_ExtFwd;
        internal static bool _DPSU_Motor_ExtBwd;


        internal static bool _DPSU_Motor_RelaxTiltUp;
        internal static bool _DPSU_Motor_RelaxTiltDown;

        /*[APSU]*/
        //DIANOIST
        internal bool _DiagnoistMode_APSU = false;
        internal bool _DiagnoistOnFlag_APSU = false;
        internal bool _DiagnoistMoving_APSU = false;

        internal static DianosticMotor _APSU_DianoistMotor = DianosticMotor.NONE;

        //SW
        internal static bool _APSU_Motor_SlideFwd;
        internal static bool _APSU_Motor_SlideBwd;

        internal static bool _APSU_Motor_HeightUp;
        internal static bool _APSU_Motor_HeightDown;

        internal static bool _APSU_Motor_TiltUp;
        internal static bool _APSU_Motor_TiltDown;

        internal static bool _APSU_Motor_ExtFwd;
        internal static bool _APSU_Motor_ExtBwd;

        internal static bool _APSU_Motor_RelaxTiltUp;
        internal static bool _APSU_Motor_RelaxTiltDown;

        //HV INSEPCTION 
        internal byte BeforeDrvOpt = 0;
        internal byte BeforeDrvState = 0;
        internal byte BeforePassOpt = 0;
        internal byte BeforePassState = 0;

        internal byte BeforeRearLhOpt = 0;
        internal byte BeforeRearLhState = 0;


        internal byte BeforeRearRhOpt = 0;
        internal byte BeforeRearRhState = 0;



        internal static eHVState DrvHVState = eHVState.OFF;
        internal static eHVState PassHVState = eHVState.OFF;

        internal static eHVState RLHVState = eHVState.OFF;
        internal static eHVState RRHVState = eHVState.OFF;


        //ECU INFO INSPECTION
        private StringBuilder sbEcuInfo = new StringBuilder();
        private bool _EcuInfoPartNoFlag = false;
        private bool _EcuInfoSwVerFlag = false;
        private bool _EcuInfoHwVerFlag = false;
        private bool _EcuInfoHallSensorFlag = false;
        private byte _EcuInfoLen = 0;
        private bool _HallSensorFlag = false;

        public ClsCan(Form main)
        {
            _main = main;
            PeriodMsg.DATA = new byte[8];
            //CAN_BUS USB 배열 초기화
            InitHandleArray();
            //Deleagte로 들어올떄 마다 canRead
            InitDelegate();
            //CRC 테이블 초기화
            InitCRCTable();
        }

        private void ConfigureTraceFile()
        {
            UInt32 iBuffer;
            TPCANStatus stsResult;

            // Configure the maximum size of a trace file to 5 megabytes
            //
            iBuffer = 5;
            stsResult = PCANBasic.SetValue(m_PcanHandle, TPCANParameter.PCAN_TRACE_SIZE, ref iBuffer, sizeof(UInt32));
            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                IncludeTextMessage(GetFormatedError(stsResult));

            // Configure the way how trace files are created: 
            // * Standard name is used
            // * Existing file is ovewritten, 
            // * Only one file is created.
            // * Recording stopts when the file size reaches 5 megabytes.
            //
            iBuffer = PCANBasic.TRACE_FILE_SINGLE | PCANBasic.TRACE_FILE_OVERWRITE;
            stsResult = PCANBasic.SetValue(m_PcanHandle, TPCANParameter.PCAN_TRACE_CONFIGURE, ref iBuffer, sizeof(UInt32));
            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                IncludeTextMessage(GetFormatedError(stsResult));
        }
        private string GetFormatedError(TPCANStatus error)
        {
            StringBuilder strTemp;

            // Creates a buffer big enough for a error-text
            //
            strTemp = new StringBuilder(256);
            // Gets the text using the GetErrorText API function
            // If the function success, the translated error is returned. If it fails,
            // a text describing the current error is returned.
            //
            if (PCANBasic.GetErrorText(error, 0, strTemp) != TPCANStatus.PCAN_ERROR_OK)
                return string.Format("An error occurred. Error-code's text ({0:X}) couldn't be retrieved", error);
            else
                return strTemp.ToString();
        }
        private void IncludeTextMessage(string strMsg)
        {
            //frmMain.CanLog.Write(strMsg);
        }
        #region clsCan 초기화
        //Pcan_Bus Handle_Array 초기화
        //USB_BUS 초기화 로직
        private void InitHandleArray()
        {
            m_HandlesArray = new TPCANHandle[]
            {

                PCANBasic.PCAN_USBBUS1,
                PCANBasic.PCAN_USBBUS2,
                PCANBasic.PCAN_USBBUS3,
                PCANBasic.PCAN_USBBUS4,
                PCANBasic.PCAN_USBBUS5,
                PCANBasic.PCAN_USBBUS6,
                PCANBasic.PCAN_USBBUS7,
                PCANBasic.PCAN_USBBUS8,
                PCANBasic.PCAN_USBBUS9,
                PCANBasic.PCAN_USBBUS10,
                PCANBasic.PCAN_USBBUS11,
                PCANBasic.PCAN_USBBUS12,
                PCANBasic.PCAN_USBBUS13,
                PCANBasic.PCAN_USBBUS14,
                PCANBasic.PCAN_USBBUS15,
                PCANBasic.PCAN_USBBUS16,
            };

            //ConfigureLogFile();
        }
        //ConfigureLogFile
        //로그 설정 파일 => SetValue 에 뭐 쓰는거 같은데 뭐쓰는건지 몰르겠슴
        private void ConfigureLogFile()
        {
            try
            {
                UInt32 iBuffer;
                //이건 대체 왜쓰는건데...
                iBuffer = PCANBasic.LOG_FUNCTION_ALL;


                PCANBasic.SetValue(PCANBasic.PCAN_NONEBUS, TPCANParameter.PCAN_LOG_CONFIGURE, ref iBuffer, sizeof(UInt32));
            }
            catch (Exception ex)
            { }
        }
        private void InitDelegate()
        {
            CanRead = new ClsCan.dlgCanRead(SafeCanRead);
        }
        //CRC 테이블 초기화=> 이거 하는이유가 비트 오류검출 할라고 만들어 놓은거라 하던데
        //기존에 있던 비트를 다 지우고 하는건가..뭐 하이튼 그런듯
        private void InitCRCTable()
        {
            CRC16 = 0xffff;
            CRCTbl = new ushort[256];

            int i;
            const ushort POLY = 0x1021;

            for (i = 0; i < 256; i++)
            {
                ushort crc = 0;
                ushort c = (ushort)(((ushort)i) << 8);
                int j;
                for (j = 0; j < 8; j++)
                {
                    if (((crc ^ c) & 0x8000) != 0)
                    {
                        crc = (ushort)((crc << 1) ^ POLY);
                    }
                    else
                    {
                        crc = (ushort)(crc << 1);
                    }
                    c = (ushort)(c << 1);
                }

                CRCTbl[i] = crc;
            }
        }
        #endregion
        #region Can_Open
        public void Can_Open()
        {
            TPCANStatus stsResult;
            if (fnGet_Handle(Channel) == null)
                return;


            m_PcanHandle = (TPCANHandle)fnGet_Handle(Channel);
            m_Baudrate = fnGet_Speed(Baudrate);
            m_HwType = TPCANType.PCAN_TYPE_ISA;

            Can_Close();
            if (PCANBasic.GetStatus(m_PcanHandle) != TPCANStatus.PCAN_ERROR_BUSOFF)
                PCANBasic.Uninitialize(m_PcanHandle);

            try
            {
                string tmp = "f_clock=80000000,nom_brp=1,nom_tseg1=132,nom_tseg2=27,nom_sjw=27,data_brp=2,data_tseg1=29,data_tseg2=10,data_sjw=10";

                stsResult = PCANBasic.InitializeFD(m_PcanHandle, tmp);

                if (m_thread_Can != null)
                {
                    m_thread_Can.Abort();
                    m_thread_Can = null;
                }

                if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                {
                    if (stsResult != TPCANStatus.PCAN_ERROR_CAUTION)
                    {
                        //frmMain.CanLog.Write(GetFormatedError(stsResult));
                    }
                    else
                    {
                        m_thread_Can = new Thread(Read);
                        stsResult = TPCANStatus.PCAN_ERROR_OK;
                    }
                }
                else
                {
                    m_thread_Can = new Thread(Read);
                    ConfigureTraceFile();
                }


                if (m_thread_Can != null)
                {
                    //m_thread_Can.Name = CanType + "Can Thread";
                    m_thread_Can.IsBackground = true;
                    m_thread_Can.Priority = ThreadPriority.Highest;
                    m_thread_Can.Start();


                    if (thrCanPeriod != null)
                    {
                        thrCanPeriod.Abort();
                        thrCanPeriod = null;
                    }
                    thrCanPeriod = new Thread(CanPeriod);
                    thrCanPeriod.IsBackground = true;
                    thrCanPeriod.Start();


                    if (IsConnect)
                    {
                        lbState.BackColor = Color.Lime;
                        lbSignal.BackColor = Color.Lime;
                    }
                    else
                    {
                        lbState.BackColor = Color.Red;
                        lbSignal.BackColor = Color.Black;
                    }
                    //frmMain.SysLog.Write((CanType == JControl.LogData.enCanType.L_CAN ? "[L]" : "[M]") + "Can Open " + (Baudrate == 0 ? "100K" : "500K"));
                    //frmMain.CanLog.Write("Can Open", true, true, JControl.LogData.enTransType.NONE, CanType, MethodBase.GetCurrentMethod().Name);

                }
                else
                {
                    //throw new Exception(CanType + "Can is Null");
                }

            }
            catch (Exception ex)
            { 
                //Debug.WriteLine(CanType + "Can Open Error : " + ex.Message); 
            }


        }
        /// <summary>
        /// 채널 포트 식별
        /// </summary>
        /// <param name="Channel"></param>
        /// <returns></returns>
        private TPCANHandle? fnGet_Handle(string Channel)
        {
            try
            {
                string strTemp;

                if (Channel.Length < 5)
                    return null;

                strTemp = Channel.Substring(Channel.IndexOf('(') + 1, 3);
                strTemp = strTemp.Replace('h', ' ').Trim(' ');

                return Convert.ToUInt16(strTemp, 16);
            }
            catch (Exception ex)
            {
                //frmMain.SysLog.Write(CanType + " Get Handle Fail : " + ex.Message);
                return null;
            }

        }
        /// <summary>
        /// CAN 채널 보더레이트
        /// </summary>
        /// <param name="Speed"></param>
        /// <returns></returns>
        private TPCANBaudrate fnGet_Speed(int Speed)
        {
            switch (Speed)
            {
                case 0:
                    return TPCANBaudrate.PCAN_BAUD_100K;
                case 1:
                    return TPCANBaudrate.PCAN_BAUD_500K;
                default:
                    return TPCANBaudrate.PCAN_BAUD_100K;
            }
        }
        #endregion
        #region Can_Close
        //CAN_BUS 꺼지면 Thread 중지->상태 색깔 빨간색
        public void Can_Close()
        {
            if (PCANBasic.GetStatus(m_PcanHandle) != TPCANStatus.PCAN_ERROR_BUSOFF)
            {
                PCANBasic.Uninitialize(m_PcanHandle);
                //frmMain.SysLog.Write((CanType == JControl.LogData.enCanType.L_CAN ? "[L]" : "[M]") + "Can Close ");
                //frmMain.CanLog.Write("Can Close", true, true, JControl.LogData.enTransType.NONE, CanType, MethodBase.GetCurrentMethod().Name);

                if (m_thread_Can != null)
                {
                    m_thread_Can.Abort();
                    m_thread_Can = null;
                }

                if (thrCanPeriod != null)
                {
                    thrCanPeriod.Abort();
                    thrCanPeriod = null;
                }


                if (IsConnect)
                    lbState.BackColor = Color.Lime;
                else
                {
                    lbState.BackColor = Color.Red;
                    lbSignal.BackColor = Color.Black;
                }
            }
        }
        #endregion
        #region Can_Reading
        private void Read()
        {
            try
            {
                while (true)
                {
                    _main.Invoke(CanRead);
                    Thread.Sleep(50);

                    if (IsConnect)
                        lbState.BackColor = Color.Lime;
                    else
                    {
                        lbState.BackColor = Color.Red;
                        lbSignal.BackColor = Color.Black;
                    }

                }
            }
            catch (Exception ex)
            { 
                //frmMain.CanLog.Write("Can Read Error : " + ex.Message, true, true, JControl.LogData.enTransType.NONE, CanType, MethodBase.GetCurrentMethod().Name); 
            
            }
        }


        private void CanPeriod()
        {
            Tick_50.Start();
            Tick_100.Start();
            Tick_200.Start();
            while (true)
            {
                try
                {
                    Thread.Sleep(50);
                    if (IsConnect == false)
                        continue;
                    //if (frmMain.CurrentModel == null)
                    //    continue;
                    //    if (frmMain.CurrentModel == null)
                    //        continue;

                    //    if (frmMain.CurrentModel.Car == clsModel.eCar.SV)
                    //    {
                    //        //SW 
                    //        if (CanType == JControl.LogData.enCanType.L_CAN)
                    //        {
                    //            if (Tick_200.ElapsedMilliseconds >= 200)
                    //            {
                    //                if (frmMain.CurrentModel.fnGetIsDrv())
                    //                    CanFDWrite_PSS_DRV_FD_01_200ms();
                    //                else
                    //                    CanFDWrite_PSS_AST_FD_01_200ms();


                    //                Tick_200.Restart();
                    //            }
                    //        }
                    //        //Main
                    //        else
                    //        {

                    //            if (Tick_50.ElapsedMilliseconds >= 50)
                    //            {


                    //                Tick_50.Restart();
                    //            }

                    //            if (Tick_100.ElapsedMilliseconds >= 100)
                    //            {

                    //                Tick_100.Restart();
                    //            }
                    //            if (Tick_200.ElapsedMilliseconds >= 200)
                    //            {
                    //                CanFDWrite_BDC_FD_02_200ms(1); //Signal IGN
                    //                Tick_200.Restart();
                    //            }
                    //        }
                    //    }
                    //    else if (frmMain.CurrentModel.Car == clsModel.eCar.CT)
                    //    {
                    //        //SW 
                    //        if (CanType == JControl.LogData.enCanType.L_CAN)
                    //        {
                    //            if (Tick_200.ElapsedMilliseconds >= 200)
                    //            {
                    //                if (frmMain.CurrentModel.fnGetIsDrv())
                    //                    CanFDWrite_PSS_DRV_FD_01_200ms();
                    //                else
                    //                    CanFDWrite_PSS_AST_FD_01_200ms();


                    //                Tick_200.Restart();
                    //            }
                    //        }
                    //        //Main
                    //        else
                    //        {

                    //            if (Tick_50.ElapsedMilliseconds >= 50)
                    //            {


                    //                Tick_50.Restart();
                    //            }

                    //            if (Tick_100.ElapsedMilliseconds >= 100)
                    //            {

                    //                Tick_100.Restart();
                    //            }
                    //            if (Tick_200.ElapsedMilliseconds >= 200)
                    //            {
                    //                CanFDWrite_BDC_FD_02_200ms(1); //Signal IGN
                    //                Tick_200.Restart();
                    //            }
                    //        }
                    //    }
                    //    else if (frmMain.CurrentModel.Car == clsModel.eCar.TK)
                    //    {
                    //        //SW 
                    //        if (CanType == JControl.LogData.enCanType.L_CAN)
                    //        {
                    //            if (Tick_200.ElapsedMilliseconds >= 200)
                    //            {
                    //                if (frmMain.CurrentModel.fnGetIsDrv())
                    //                    CanFDWrite_PSS_DRV_FD_01_200ms();
                    //                else
                    //                    CanFDWrite_PSS_AST_FD_01_200ms();


                    //                Tick_200.Restart();
                    //            }
                    //        }
                    //        //Main
                    //        else
                    //        {

                    //            if (Tick_50.ElapsedMilliseconds >= 50)
                    //            {


                    //                Tick_50.Restart();
                    //            }

                    //            if (Tick_100.ElapsedMilliseconds >= 100)
                    //            {

                    //                Tick_100.Restart();
                    //            }
                    //            if (Tick_200.ElapsedMilliseconds >= 200)
                    //            {
                    //                CanFDWrite_BDC_FD_02_200ms(1); //Signal IGN
                    //                Tick_200.Restart();
                    //            }
                    //        }
                    //    }


                    //}
                    //catch (Exception ex)
                    //{ frmMain.CanLog.Write("Can Period Tick Error : " + ex.Message, true, true, JControl.LogData.enTransType.NONE, CanType, MethodBase.GetCurrentMethod().Name); }
                }
                catch (Exception ex)
                    {

                    }
                }
        }

        private StringBuilder sbCmt = new StringBuilder();
        public void SafeCanRead()
        {
            TPCANTimestamp newTimestamp;


            byte tmpHVOptByte;
            byte tmpHVStateByte;
            byte tmpRearHeatStateByte;
            byte tmpRearVentStateByte;
            int tmpLen; 

            TPCANMsgFD tmpMsg = new TPCANMsgFD();
            tmpMsg.DATA = new byte[64];
            TPCANTimestampFD newTimestampFD;
            TPCANStatus tmpCanState;
            tmpCanState = PCANBasic.ReadFD(m_PcanHandle, out tmpMsg, out newTimestampFD);

            tmpLen = GetLengthFromDLC(tmpMsg.DLC, (tmpMsg.MSGTYPE & TPCANMessageType.PCAN_MESSAGE_FD) == 0);

            while(tmpCanState == TPCANStatus.PCAN_ERROR_OK)
            {
                sbCmt.Clear();
                sbCmt.Append("LEN[" + tmpLen.ToString() + "]");
                sbCmt.Append("DATA:");
                for(int i = 0; i < tmpLen; i++)
                {
                    sbCmt.Append(string.Format("{0:X2}", tmpMsg.DATA[i]));  
                }
                switch (clsModel.eCar.SV)
                {
                    case (clsModel.eCar)0:
                        
                    break;
                }
                switch (clsModel.eCar.CT)
                {
                    case (clsModel.eCar)1:

                        break;
                }
                switch (clsModel.eCar.TK)
                {
                    case (clsModel.eCar)2:

                        break;
                }
            }
        }
        public int GetLengthFromDLC(int dlc, bool isSTD)
        {
            if (dlc <= 8)
                return dlc;

            if (isSTD)
                return 8;

            switch (dlc)
            {
                case 9: return 12;
                case 10: return 16;
                case 11: return 20;
                case 12: return 24;
                case 13: return 32;
                case 14: return 48;
                case 15: return 64;
                default: return dlc;
            }
        }


        #endregion

    }
    }

