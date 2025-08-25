using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.Inspection.Setting
{
    public class Motor
    {

        public enum MotorItem
        {
            None,
            SLIDE,
            HEIGHT,
            TILT,
            RELAX,
            LUMB,
            LEG_EXT,
        }
        internal decimal Offset;
        internal decimal Span = 100; //기본 100%




    }
}
