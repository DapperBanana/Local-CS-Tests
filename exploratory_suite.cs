
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsNarcissisticNumber(number))
        {
            Console.WriteLine($"{number} is a narcissistic number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a narcissistic number.");
        }
    }

    static bool IsNarcissisticNumber(int number)
    {
        int originalNumber = number;
        int numDigits = (int)Math.Ceiling(Math.Log10(number + 1));

        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numDigits);
            number /= 10;
        }

        return sum == originalNumber;
    }
}
