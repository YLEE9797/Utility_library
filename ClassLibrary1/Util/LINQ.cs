using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilityLib
{
    internal class LINQ
    {
        public static string _model = "CT";
        public static string[] SampleData = new string[] { "SV", "CT", "TK" };
        public static dynamic _query=string.Empty;

        //로컬 데이터 참조 할떄 쓰기
        public static void Search()
        {
            _query=from search in SampleData
            where search == _model
            select search;
            foreach(dynamic result in _query)
            {
                Console.WriteLine(result);
            }
        }
        //특정 문자열로 시작하는거 찾을떄
        public static void TextSearch(string Text)
        {
            _query = SampleData.Where(x => x.StartsWith(Text));
            foreach (dynamic result in _query)
            {
                Console.WriteLine(result);
            }
        }

    }
}
