using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.Seat_Inspection
{
    public class SensorProcess
    {

        /// <summary>
        /// Msg 변수
        /// </summary>
        public string msg = string.Empty;
        public double[] Input;
        public double[] OutPut;


        /// <summary>
        /// 온도가 설정된 범위내에 있는지 판단하는 함수
        /// </summary>
        /// <param name="temperature">온도값</param>
        public string ValidTemperature(double temperature,double Max)
        {
            try
            {
               if(temperature< Max)
                {
                    msg = "안정된 범위입니다";
                   
                }
                else if(temperature > Max)
                {
                    msg= "온도가 너무 높습니다";
                }
            }
            catch(Exception ee)
            {
                msg = ee.Message;      
            }
            return msg;
        }
        /// <summary>
        /// 데이터 노이즈 필터링 
        ///이동 평균 필터는 간단하면서도 효과적인 노이즈 제거 방법입니다. 일정한 크기의 윈도우(window)를 사용하여 
        ///데이터를 평균 내어 갑작스러운 변화(노이즈)를 줄입니다.
        /// </summary>
        /// <param name="data"></param>
        public static List<double> MovingAverageFilter(List<double> data, int windowSize)
        {
            var filteredData = new List<double>();
            for (int i = 0; i < data.Count; i++)
            {
                int start = Math.Max(0, i - windowSize + 1);
                double average = data.Skip(start).Take(windowSize).Average();
                filteredData.Add(average);
            }
            return filteredData;
        }


        /// <summary>
        /// 합계 내는 함수
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public double Sum(double[] data)
        {
            double sum =0.0;
            for(int i = 0; i < data.Length; i++)
            {
                data[i] += sum;
            }
            return sum;
        }
        
    }
}
