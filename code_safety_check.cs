
using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }

            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
