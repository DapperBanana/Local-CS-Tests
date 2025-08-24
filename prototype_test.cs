
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int result = CalculateSumOfDigits(number);
        Console.WriteLine($"The single-digit sum is: {result}");
    }

    static int CalculateSumOfDigits(int number)
    {
        while (number > 9)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            number = sum;
        }

        return number;
    }
}
