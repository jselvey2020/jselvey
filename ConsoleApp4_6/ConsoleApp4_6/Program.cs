using System;

namespace ConsoleApp4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7];
            days[0] = "Monday";
            days[1] = "Tuesday";
            days[2] = "Wednesday";
            days[3] = "Thursday";
            days[4] = "Friday";
            days[5] = "Saturday";
            days[6] = "Sunday";

            string[] tasks = new string[7];

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine("Type in a new Task for "+ days[i]);
                tasks[i] = days[i] + ":" + Console.ReadLine();

                        
            }
            
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(tasks[i]);
            }





        }

    }
}
