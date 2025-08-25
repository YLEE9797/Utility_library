using EnumsNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.Batch
{
    public class Job
    {
        public int JobId { get; set; } // Primary Key
        public DateTime StartTime { get; set; } // Job start time
        public DateTime? EndTime { get; set; } // Job end time
        public string Status { get; set; } // Job status: Started, Completed, Failed, Partially Completed
        public int BatchSize { get; set; } // Number of payments per batch
        public int TotalBatches { get; set; } // Total number of batches for this job
        public BATCH_JOB JOB_STATUS;

        public enum BATCH_TYPE
        {
            DB,//     DB 쿼리 작업등
            FILES,//  FILE
            STATICS// 통계
        }

        public enum BATCH_JOB
        {
            IDLE,//IDLE
            START,//START
            RUNNING,//실행중
            Complete,//완료
            FAIL,//실패
            UNKNOWN,//알수없음
            ABANDONDED//버려짐
        }
        
       //Job 초기화
       public void initJobs()
        {
            JobId = 0;
            JOB_STATUS =BATCH_JOB.IDLE;
            Status = "IDLE";
        }
        //Batch 스텝
        public void NextBatch(BATCH_JOB JOB)
        {
            if (JOB == BATCH_JOB.IDLE)
            {
                JOB_STATUS = BATCH_JOB.START;
            }
            else if (JOB == BATCH_JOB.START)
            {
                JOB_STATUS = BATCH_JOB.Complete;
            }

        }
        //Job 시작
        public void StartJob(BATCH_TYPE TYPE)
        {
          
            Task.Run(() =>
            {
                if (JOB_STATUS == BATCH_JOB.IDLE)
                {
                    Console.WriteLine("BATCH STATUS  : IDLE");
                    NextBatch(JOB_STATUS);
                }
                else if (JOB_STATUS == BATCH_JOB.START)
                {

                    Console.WriteLine("BATCH STATUS : START");
                    StartTime = DateTime.Now;
                    Console.WriteLine("Excution Time : " + StartTime.ToString());
                    //실행 로직(로그 처리)
                    if (TYPE == BATCH_TYPE.DB)
                    {

                    }
                    //DB 실행로직(DB)
                    else if (TYPE == BATCH_TYPE.FILES)
                    {

                    }
                    //통계(STATICS)
                    else if (TYPE == BATCH_TYPE.STATICS)
                    {

                    }

                    double EndTime = (StartTime - DateTime.Now).TotalSeconds;
                    Console.WriteLine("Excution EndTime : " + EndTime);
                   
                }
            });
        }
        //Job 완료
        public void CompleteJob()
        {
           
        }

        //배치 실패시 로직
        public void FailJob()
        {

        }
    }
}
