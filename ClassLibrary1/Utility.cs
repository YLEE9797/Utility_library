using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    struct Model
    {
        //차량
        public int Car;
        //Drv(LHD/RHD)
        public int Drv;
        //Position(LH/RH)
        public int Position;
        //Type(IMS/RELAX/WALKIN/POWER/MANUAL)
        public int Type;
        //HV(HEAT/VENT/NONE)
        public int HV;
        //HV_PartNo
        public string HV_PartNo;
        //HV_SW_VER
        public string HV_SWVer;
        //HV_HW_VER
        public string HV_HWVer;
        //IMS_PartNo
        public string IMS_PartNo;
        //IMS_HWVer
        public string IMS_HWVer;
        //IMS_SWVer
        public string IMS_SWVer;
    }

    public static class Utility
    {
        static List<Model> ModelList = new List<Model>();
        static List<Model> list = new List<Model>();

        public static void Print<T>(this List<T> lst)
        {
            lst.ForEach(r => Console.Write(r));
            Console.WriteLine();
        }
        public static void Print(this Dictionary<int, string> dic)
        {
            foreach(var key in dic)
            {
                Console.WriteLine($"{key.Value} {dic[key.Key]}");
            }
            Console.WriteLine();
        }
        public static void AddModel(int Car,int Type,int HV,string HV_PartNo,string HV_HWVer,string HV_SWVer,string IMS_PartNo,string IMS_HWVer,string IMS_SWVer)
        {
            ModelList.Add(new Model {
                Car = Car, 
                Type = Type,
                HV=HV,
                HV_PartNo=HV_PartNo,
                HV_HWVer=HV_HWVer,
                HV_SWVer=HV_SWVer,
                IMS_PartNo=IMS_PartNo,
                IMS_HWVer=IMS_HWVer,
                IMS_SWVer=IMS_SWVer,
            });
        }
        public static void FindModel(int Car)
        {
            foreach (var model in ModelList)
            {
                list.FindAll(m => m.Car == Car);
            }
            list.Print();
        }
        public static List<int> Distinct(this List<int> list)
        {
            list = list.Distinct().ToList();
            return list;
        }
        static int GetListCount<T>(List<T> lstTemplate_)
        {
            return lstTemplate_?.Count ?? 0;
        }
        //모델을 찾아보고 모델이 없으면 모델추가 하기
        public static void FindAdd(int Car)
        {
            FindModel(Car);
            if (Car.CompareTo(Car) ==Car)
            {
                Console.WriteLine(Car +"모델이 있습니다");
                return;
            }
            else
            {
                //나중에 Car 부터 DRv 까지 넣기)
                //AddModel()
            }
        }
        //똑같은 모델찾기(List 에 Car Model 이랑 Car 모델 똑같은 모델 찾기)
        static List<Model> FindSameModel(List<Model>Model,int Car)
        {
            return Model.FindAll(delegate (Model md)
            { return md.Car == Car; }
            );
        }
      
    }
}
