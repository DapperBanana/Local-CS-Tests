
using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
            }

            Console.WriteLine("The sum of digits is: " + sum);
        }
    }
}
