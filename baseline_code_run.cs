
using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = CalculateDigitSum(number);

            Console.WriteLine($"Sum of digits until it becomes a single-digit number: {sum}");
        }

        public static int CalculateDigitSum(int number)
        {
            while (number > 9)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                number = sum;
            }
            return number;
        }
    }
}
