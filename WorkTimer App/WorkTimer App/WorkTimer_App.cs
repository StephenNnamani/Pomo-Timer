using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimer_App
{
    internal class Worker
    {
        public string RestTimer(int RestInterval)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(RestInterval);
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}"
                 , ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            return elapsedTime;
        }
        public string WorkerTimer(int WorkInterval)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(WorkInterval);
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}"
                , ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            return elapsedTime;
        }
        public static ArrayList numberOfWork(int numberOfTask)
            {
                var tasks = new ArrayList();
                int i = 0;
                while (numberOfTask != i)
                {
                    int s = i + 1;
                    Console.WriteLine("What is your Task number" + s);
                    string? TaskName = Console.ReadLine();
                    tasks.Add(TaskName);
                    
                    i++;
                }

                return tasks;
            }
        }
    
}
