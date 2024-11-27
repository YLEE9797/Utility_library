using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    internal class ConvertType
    {
        public void ConvertIntToHex<TInput, TOutPut>(TInput input, Converter<TInput, TOutPut> converter)
        {
            Console.WriteLine(converter(input));
        }
        
        //ConvertTwice("Another string",text=>text.Length,length=>Math.Sqrt(length));
        static void Convert_byte_Int_Hex<Tinput,TMiddle,TOutput>(Tinput input, Converter<Tinput, TMiddle> firstConvert, Converter<TMiddle, TOutput> secondConvert)
        {
            TMiddle middle = firstConvert(input);
            TOutput output = secondConvert(middle);
            Console.WriteLine(output);
        }
    }
}
