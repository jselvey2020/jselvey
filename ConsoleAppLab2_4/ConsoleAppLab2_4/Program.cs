using System;

namespace ConsoleAppLab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
          var myFirstNumber = 19;
          var mySecondNumber = 244;
            Console.WriteLine(myFirstNumber * mySecondNumber);
            string myText = "Some Text";
            Console.WriteLine(myText + mySecondNumber);
            string moreText = "Goes Here";
            Console.WriteLine(myText+moreText);
            string color1 = "Yellow";
            string color2 = "Red";
            bool isYellow = true;
            bool isGreen = false;
            Console.WriteLine(color1 +isYellow + color2 + isGreen);
            double numbers;
            numbers = mySecondNumber / myFirstNumber;
            Console.WriteLine(numbers);
            numbers = mySecondNumber / (double)myFirstNumber;
            Console.WriteLine(numbers);
            Console.WriteLine("BreakPoint Here");

        }
    }
}
