using System;

namespace ConsoleAppLab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Give Me A Number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Me Another Number");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("When Added");
            int result = number1 + number2;
            Console.WriteLine(result);

            Console.WriteLine("When Subtracted");
            result = number1 - number2;
            Console.WriteLine(result);

            Console.WriteLine("When Multiplied");
            result = number1 * number2;
            Console.WriteLine(result);

            Console.WriteLine("When Divided");
            result = number1 / number2;
            Console.WriteLine(result);

            Console.WriteLine("What Is Your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + " " + name);

            int multi1;
            int multi2;
            int multi3;
            Console.WriteLine("Give Me A Number");
            multi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Me Another Number");
            multi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Me A Third Number");
            multi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now I'll Multiply Them All Together");
            result = multi1 * multi2 * multi3;
            Console.WriteLine(result);

            Console.WriteLine("Tell Me How Old You Are?");
            string age = Console.ReadLine();
            Console.WriteLine("You Look Much Younger Than " + age);
            Console.WriteLine("Have A Good Day");








        }
    }
}
