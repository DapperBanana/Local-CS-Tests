
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsHarshadNumber(number))
        {
            Console.WriteLine($"{number} is a Harshad number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Harshad number.");
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
