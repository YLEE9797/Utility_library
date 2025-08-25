using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UtilityLib.Plc
{
    public class clsPlc
    {
        public string ip;
        public int Port;
        public Thread ThrPlc;
        public IPEndPoint IPEndPoint;
        public Socket PlcSocket;
        public Label lbPlcState;
        public Log.Log log = new Log.Log();

        public clsPlc(string ip, int port, Label lbState)
        {
            this.ip = ip;
            this.Port = port;
            this.IPEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            this.PlcSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.lbPlcState = lbState;
        }


        public void ConnectPlc()
        {
            try
            {
             
            }
            catch(Exception ee)
            {
            log.LogErr(string.Format("PLC 연결 실패: {0}", ee.Message));
            }
        }


    }
}
