using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimer_App
{
    internal class Worker
    {
            public string WorkerTimer(int duration)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Thread.Sleep(duration);

                TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}"
                , ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            return elapsedTime;
            }
            public static string[] numberOfWork(int numberOfTask)
            {
                string?[] tasks = new string[numberOfTask];
                int i = 0;
                while (numberOfTask > 0)
                {
                    Console.WriteLine("What is your Task number" + i);
                    tasks[i] = Console.ReadLine();
                }

                return tasks;
            }
        }
    
}
