using System;
using System.Collections.Generic;
namespace ConsoleApp4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> highScores = new List<int>();
            
                highScores.Add(4400);
                highScores.Add(8900);
                highScores.Add(1200);
                highScores.Add(3700);
                highScores.Add(7200);

                highScores.Sort();

            
                highScores.Reverse();
            foreach (int score in highScores)
            {

                Console.WriteLine(score);
            }

            highScores.Add(2400);

            highScores.Remove(4400);




        }
    }
}
