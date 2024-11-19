using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    struct Model
    {
        public int Car;
        public string Type;
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
        public static void AddModel(int Car,string Type)
        {
            ModelList.Add(new Model { Car = Car, Type = Type });
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

    }
}
