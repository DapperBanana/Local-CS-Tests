
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sumOfDigits = CalculateSumOfDigits(number);

        Console.WriteLine("Sum of digits: " + sumOfDigits);
    }

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        return sum;
    }
}
