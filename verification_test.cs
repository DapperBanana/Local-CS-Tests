
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is a narcissistic number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsNarcissisticNumber(number))
        {
            Console.WriteLine(number + " is a narcissistic number.");
        }
        else
        {
            Console.WriteLine(number + " is not a narcissistic number.");
        }
    }

    static bool IsNarcissisticNumber(int number)
    {
        int numDigits = (int)Math.Floor(Math.Log10(number) + 1);
        int sum = 0;
        int originalNumber = number;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numDigits);
            number /= 10;
        }

        return sum == originalNumber;
    }
}
