using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    internal class Propertie
    {


        //모델리스트 일떄(모델 여러개일때)
        List<Model> Model_List = new List<Model>(); 
        public List<Model> ModelList { get { return Model_List; } }
        //모델(단일 모델일때)
        public static string Model { get; private set; }
        //LHD/RHD
        public string Drv {  get; private set; }
        //LH/RH
        public string Positon { get; private set; }
        //IMS,RELAX,WALKIN
        public string Type { get; private set; }
        //HEAT/VENT
        public string HV { get; private set; }
        //CUSHION
        public string Cush { get; private set; }
        //FOLD
        public string Fold { get; private set; }
        //LUMB
        public string Lumb { get; private set; }
        //WAY
        public string Way { get; private set; }
        //LIMIT 재검사 Count
        public int LimitRestestCount { get; private set; }
        //HEAT_VENT LIMIT 재검사 Count
        public int HeatVentRetestCount { get; private set; }
       
       
    }
}
