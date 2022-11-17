
namespace WorkTimer_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Worker Worker = new Worker();
            Console.WriteLine("What is your name, new guest?");
            string? name = Console.ReadLine();
            Console.WriteLine("Good Day" + name);
            Console.WriteLine("===========================================================");
            Console.WriteLine("You are welcomed to the day's tasks");
            Console.WriteLine("Hope you are feeling well today :)");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Pease, how many tasks do you have for today?");
            int numberOfTask = Convert.ToInt32(Console.ReadLine());
            string[] TaskList = Worker.numberOfWork(numberOfTask);
            Console.WriteLine("how many MINUTES will it take to accomplish each Task");
            int[] sumTime = new int[TaskList.Length];
            foreach(string task in TaskList)
            {
                int i = 0;
                Console.WriteLine("How many minutes are you assigning to this task?");
                Console.WriteLine(task);
                sumTime[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Worker.WorkerTimer(duration);
        }
    }
}