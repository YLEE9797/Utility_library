using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UtilityLib.Log;

namespace SJ_FNC
{


    public enum TcpConnectionState
    {
        Open,
        Close,
        Fetch
    }


    public class clsTcp
    {
        public string tcp_IP;
        public int tcp_port;
        public Log Log;
        public Socket Client;
        public NetworkStream tcp_stream;
        public Socket socket;
        public clsTcp(string ip,int Port,Socket TcpClient)
        {
            ip = this.tcp_IP;
            Port =this.tcp_port;
            Client = TcpClient;
            socket =new Socket(SocketType.Stream, ProtocolType.Tcp);
            tcp_stream = new NetworkStream(Client);
        }

        public void ConnectToTcp()
        {


            //Thread로 동작하고 Client 로 동작
            //Tcp 연결 ->연결상태->연결시도->
            //연결실패한 조건일떄(비동기로)->상태 업데이트
            //연결성공한 조건일떄(비동기로)->계속 유지 또는 PING
            try
            {
          if(Client == null) { Log.LogErr("Client 가 없습니다.");return; }
                else
                {
                   Client.ConnectAsync(IPAddress.Parse(tcp_IP), tcp_port);
              
                    if (Client.Connected)
                    {
                        Log.LogInfo("연결 되었습니다");
                    }
                    else
                    {
                        Log.LogInfo("연결되지 않았습니다");
                        return;
                    }
                }
            }

            catch(Exception e)
            {
                Log.WarnLog(e.Message);
            }
        }
        public void SendCode(string Data)
        {
            try
            {
                byte[] strData = new byte[Data.Length];

                if (Client!=null && Client.Connected)
                {
                    tcp_stream.Write(strData);
                    Log.LogInfo(tcp_IP + ":" + "전송" + strData);
                }   
            }
            catch(Exception ee)
            {
                Log.WarnLog(ee.Message);
            }
        }

    }
}
