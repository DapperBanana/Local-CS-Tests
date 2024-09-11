
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = CalculateSumOfDigits(number);

        while (sum >= 10)
        {
            sum = CalculateSumOfDigits(sum);
        }

        Console.WriteLine("Sum of digits until single-digit number: " + sum);
    }

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}
