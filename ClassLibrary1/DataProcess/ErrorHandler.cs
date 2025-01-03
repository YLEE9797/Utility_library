using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.DataProcess
{
    //오류 처리: ErrorHandler에서 발생한 오류를 처리하고 재시도 또는 중단 여부 결정
    internal class ErrorHandler
    {
        public static string _FilePath = string.Empty;

        public ErrorHandler(string FilePath)
        {
            _FilePath = FilePath;
        }
    }
}
