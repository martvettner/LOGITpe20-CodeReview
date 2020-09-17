using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks the user to enter two numbers and prints out the sum of these numbers*/
            Console.WriteLine("enter first number");
            int FirstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int secondNum = Int32.Parse(Console.ReadLine());

            int Sum = FirstNumber + secondNum;

            Console.WriteLine($"{FirstNumber} + {secondNum} = {Sum}");

        }
    }
}
