using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.Device
{
    public class DeviceConnect
    {

        //디바이스 타입과 IP와 PORT 선택
        //디바이스 타입에 따라서 연결하는것도 달라짐

        //Crevis,PLC 이더넷 통신
    public enum DeviceList
        {
            CREVIS,
            WAGO,
            BeckOff_EtherCat,
            HWG_STE,
            Papouch_TME,
            DAQ,
            PCI,
        }

        #region Crevis 정의

        private CrevisFnIO m_cFnIo = new CrevisFnIO();
        private Int32 m_Err = 0;
        private IntPtr m_hSystem = new IntPtr();
        private IntPtr m_hDevivce = new IntPtr();
        private CrevisFnIO.DEVICEINFOMODBUSTCP2 DeviceInfo = new CrevisFnIO.DEVICEINFOMODBUSTCP2();

        //Read Val
        private byte[] pInputImage = null;
        private byte[] pOutputImage = null;

        private int InputImageSize = 0;
        private int OutputImageSize = 0;

        #endregion
        public DeviceList DeviceType;//디바이스 타입
        public string EtherNet_IP;//이더넷 IP
        public int EtherNet_Port;//이더넷 PORT

        //디바이스 리스트 이름과,ip와,Port
        public DeviceConnect(DeviceList Device,string ip,int Port)
        {
            Device = DeviceType;
            this.EtherNet_IP = ip;
            this.EtherNet_Port = Port;
        }
        public bool CrevisOpen()
        {

        }
        #region Connect
        public bool Connect()
        {
            try
            {
                switch (DeviceType)
                {
                    case DeviceList.CREVIS:
                      
                        break;
                    case DeviceList.WAGO:
                        break;
                    case DeviceList.BeckOff_EtherCat:
                        break;
                    case DeviceList.HWG_STE:
                        break;
                    case DeviceList.Papouch_TME:
                        break;
                    case DeviceList.DAQ:
                        break;
                    case DeviceList.PCI:
                        break;
                    default:
                        return false;
                }
                return true;
            }
            catch(Exception ee)
            {
                return false;
            }
        }

        public void DisConnect()
        {
            try
            {

            }
            catch(Exception ee)
            {
                
            }
        }
        #endregion
    }
}
