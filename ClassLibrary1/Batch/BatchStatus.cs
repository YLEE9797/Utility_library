using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.Batch
{
    internal class BatchStatus
    {
        
        public void BatchCompare(Task t1,Task t2)
        {
            try{

                if(t1==null || t2 == null) { return; }
                //내가 하고 싶은게 t1 의 Task 랑 t2 의 Task 를 비교하는 과정
                    //시나리오 : t1과 t2 를 비교 했을떄
                    //t1 이 끝났다->기다렸다가 t2 시작
                    //t2 가 먼저 끝났다 -> t1 기다렸다가 시작
                    if (t1.IsCompleted)
                    {
                        t2.Wait();
                        t2.Start();
                    }
                    else if (t2.IsCompleted)
                    {
                        t1.Wait();
                        t1.Start();
                    }
            }
            catch (Exception ee)
            {
                
            }
        }
    }
}
