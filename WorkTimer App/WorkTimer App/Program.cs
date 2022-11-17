
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace WorkTimer_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetWindowSize(50, 20);
            Console.Clear();
            Worker Worker = new Worker();
            Console.WriteLine("What is your name, new guest?");
            string? name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Good Day " + name);
            Console.WriteLine("===========================================================");
            Console.WriteLine("You are welcomed to the day's tasks");
            Console.WriteLine("Hope you are feeling well today :)");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("How many minutes intervals do you want to focus on work? e.g 1.30 is 1min 30sec One minute & thirty seconds");
            Double WorkInterval2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many minutes intervals do you want to REST? e.g 1.30 is 1min 30sec One minute & thirty seconds");
            Double RestInterval2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Pease, how many tasks do you have for today?");
            int numberOfTask = Convert.ToInt32(Console.ReadLine());
            ArrayList TaskList = Worker.numberOfWork(numberOfTask);
            Console.WriteLine("how many MINUTES will it take to accomplish each Task");
            Double[] sumTime = new Double[numberOfTask];
            int i = 0;

            foreach (string task in TaskList)
            {
                Console.Clear();
                Console.WriteLine("How many minutes are you assigning to this task?");
                Console.WriteLine(task);
                sumTime[i] = Convert.ToDouble(Console.ReadLine());
                i++;
            }
            int duration = Convert.ToInt32(sumTime.Sum()*60*1000);
            int WorkInterval = Convert.ToInt32(WorkInterval2 * 60 * 1000);
            int RestInterval = Convert.ToInt32(RestInterval2 * 60 * 1000);

            Console.Clear();
            Console.WriteLine("Work Interval: " + WorkInterval + "\nRest Interval: " + RestInterval +  "\nDuration: "+duration);
            Console.WriteLine("Press any key to start!");
            Console.ReadKey();


            bool continueTask = false;
            int totalTime = duration;
            while(continueTask == false)
            {
                Console.Clear();
                Console.WriteLine(WorkInterval/60000 + "Minute(s) "+"WORK HOUR");
                var elapsedTime = Worker.WorkerTimer(WorkInterval);
                Console.WriteLine(elapsedTime);
                totalTime = totalTime - WorkInterval;
                Console.Beep();
                Console.WriteLine("Press any key to start Resting");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(RestInterval/60000 + "Minute(s) " + " REST STARTED");
                Worker.RestTimer(RestInterval);

                Console.Clear();
                Console.WriteLine("Press any key to continue your work");
                if (totalTime <= 0)
                {
                    continueTask = true;
                }
                else
                {
                    Console.Write("Do you wish to continue? Y or N: ");
                    string? answer = Console.ReadLine();
                    if(answer == "N")
                    {
                        continueTask = true;
                    }
                }

                Console.Clear();

            }

        }
    }
}