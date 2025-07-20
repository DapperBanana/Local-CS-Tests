
using System;

namespace HarshadNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsHarshadNumber(number))
            {
                Console.WriteLine($"{number} is a Harshad (Niven) number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a Harshad (Niven) number.");
            }
        }

        static bool IsHarshadNumber(int number)
        {
            int sumOfDigits = 0;
            int originalNumber = number;

            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            return originalNumber % sumOfDigits == 0;
        }
    }
}
