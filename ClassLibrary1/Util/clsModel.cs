using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.Util
{
    public class clsModel
    {
        #region [사양 열거형]
        public enum eCar
        {

            SV = 0,
            CT = 1,
            TK = 2,
            GN7 = 3,
            MV = 4,
        }
        public enum eDrv
        {
            LHD = 0,
            RHD = 1,
        }
        public enum ePosition
        {
            LH = 0,
            RH = 1
        }
        public enum eType
        {
            _MANUAL = 0,
            _POWER = 1,
            _IMS = 2,
            _RELAX = 3,
            //_WALKIN=4
        }
        //public enum eCush
        //{
        //    NONE = 0,
        //    CUSH = 1
        //}

        /* 옵션 열거 */
        public enum eHeatVent
        {
            NONE,
            HEAT,
            VENT,
        }

        public enum eWalkIn
        {
            NONE,
            WALKIN
        }
        //public enum eFold
        //{
        //    NONE,
        //    FOLD,
        //}
        //public enum eLumb
        //{
        //    _NONE,
        //    _2WAY,
        //    _7CELL
        //}
        //public enum eLeg
        //{
        //    NONE,
        //    LEGREST
        //}

        public enum eEcu
        {
            DPSU,
            APSU,
            //HV,
            SHVU,
            HU
        }


        public enum eMotorType
        {
            NONE,
            SLIDE,
            HEIGHT,
            TILT,
            RELAXTILT,
            //CUSH,
            RECL

        }

        #endregion 
    }
}
