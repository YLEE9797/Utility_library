using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.Batch
{
    public class Batch
    {
        List<Task> task;


        /// <summary>
        /// Task List 를 병렬로 처리 하게 만든 메서드
        /// </summary>
        public void BatchProcess()
        {
            task = new List<Task>();
            {
                new Task(() => Console.WriteLine(task[0].Id));
                new Task(() => Console.WriteLine(task[1].Id));
                new Task(() => Console.WriteLine(task[2].Id));
                new Task(() => Console.WriteLine(task[3].Id));
            };
            Parallel.ForEach(task, task =>
            {
                task.Start();
                task.Wait();
            });
        }
    }
}
