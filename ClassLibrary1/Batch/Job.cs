using System;
using System.Collections.Generic;
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

        List<string> Jobs;


       public void initJobs()
        {
            JobId = 0;
            Status = "IDLE";
        }

        

    }
}
