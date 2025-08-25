using Mysqlx;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib.Log;

namespace UtilityLib.Inspection.Setting
{
    public class Communication
    {
        private Form MainForm;
        private Thread ThrOpen;
        private Thread m_thrPOP;
        internal NetworkStream m_nsPOP;
        public const int STX = 0x02;
        private bool m_blPOPThrRepeater = true;
        internal Button btnPOP;
        internal Button btnSignal;
        public Log.Log Log;
        public const char DIVIDER = ';';
        public const int RECEIVE_REQUEST = 15;
        public const int RECEIVE_MSG = 16;
        public Common common;
        public const int SEND_REQUEST = 13;
        public const int RECEIVE_SNO = 11;
        internal static bool Result_Ack = true;
        public const int ACK = 14;

        public Communication(Form form)
        {
            MainForm = form;
        }

        #region POP_연결
        public void POP_Connect()
        {
            try
            {
                ThrOpen = new Thread(delegate ()
                {
                    m_thrPOP = new Thread(ReceivePOPData);
                });
            }
            catch(Exception ee)
            {

            }
        }
        #endregion
        #region RECEIVE_POP[POP 데이터 처리부분]
        private void ReceivePOPData()
        {
            List<byte> lsTmp = new List<byte>();
            while (m_blPOPThrRepeater)
            {
                try
                {
                    while (true)
                    {
                        byte[] buf = new byte[128];
                        m_nsPOP.Read(buf, 0, 1);
                        if (buf[0].ToString() == STX.ToString())
                            break;
                    }
                    string strTemp = Encoding.Default.GetString(lsTmp.ToArray<byte>());
                    Log.LogInfo("RECEIVE :" + strTemp);
                    string[] arrTmp = strTemp.Split(DIVIDER);
                    switch (Convert.ToInt32(arrTmp[1]))
                    {
                        case RECEIVE_SNO:
                            MainForm.Invoke(POPReceiveProcess, new object[] { arrTmp });
                            break;
                        case RECEIVE_REQUEST:
                            break;
                        case ACK:
                            if (Result_Ack == false)
                            {
                                Result_Ack = true;
                                Log.LogInfo("RECEIVE : ACK");
                            }
                            break;
                        case RECEIVE_MSG:

                            break;
                    }

                    //{
                    //    btnSignal.BackColor = btnSignal.BackColor == Color.Lime ? Color.White : Color.Lime;

                    //}
                }
                catch(Exception ee)
                {

                }
            }
        }
        #endregion

        public delegate void dlgPOPReceiveProcess(string[] strdata);
        public dlgPOPReceiveProcess POPReceiveProcess;

        public void safePOPReceiveProcess(string[] strData)
        {
            /* 구분     데이터               내용                  비고
 *  00      STX                 시작구분자
 *  01      11                  코드(사양전송)        
 *  02      88500-3TM00         품번                  제품 X=> EMPTY
 *  03      JIGNO               지그번호                
 *  04      MV                  차종                  GN7/MV/ME
 *  05      LHD                 운전석                LHD/RHD
 *  06      LH                  좌석                  LH/RH
 *  07      SERIALNO            일련번호               
 *  08      TYPE                트랙타입              NORMAL/SWIVEL/4WAY/6WAY/8WAY
 *  09      IMS                 IMS유무               IMS/N-IMS
 *  10      RELAX               RELAX 유무            NONE/RELAX
 *  11      LUMB                럼버                  NONE/2WAY/4WAY/7CELL
 *  12      HEAT                히터                  NONE/HEAT/DHPX
 *  13      VENT                통풍                  NONE/VENT/DVPH/DVPX
 *  14      CUSH                쿠션익스텐션          NONE/CUSH
 *  15      LEGREST             레그레스트            NONE/LEGREST
 *  16      HEV                 하이브리드            NONE/HEV
 *  17      WALKIN              워크인유무            NONE/WALKIN
 *  18      FOLD                폴딩 유무             NONE/FOLD
 *  19      BLUELINK            블루링크              NONE/BLUELINK
 *  20      PODS                PODS                  NONE/PODS
 *  21      DOM                 내수/수출             DOM/EXP  
 *  22      PSU PARTNO          IMS ECU 품번          
 *  23      PSU SW VER          IMS ECU SW VER
 *  24      PSU HW VER          IMS ECU HW VER
 *  25      SHVU PARTNO         HV ECU 품번
 *  26      SHVU SW VER         HV ECU SW VER
 *  27      SHVU HW VER         HV ECU HW VER
 *  28      PE                  PE                    NONE/PE
 *  29      22                  년식
 *  30      10                  전체 계획수량
 *  31      2                   현재 투입수량
 *  32      ETX                 종료구분자
 *  33
 */
            try
            {
                if (common.TEST_START)
                {
                    Log.LogInfo("검사중 사양 무시");
                }

                if (strData.Length < 12)
                    Log.LogErr("데이터 길이 오류");

            }
            catch(Exception ee)
            {

            }
        }
    }
}
