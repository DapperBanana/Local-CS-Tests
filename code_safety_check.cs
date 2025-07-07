
using System;

class Program
{
    static int CalculateDigitSum(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        while (number >= 10)
        {
            number = CalculateDigitSum(number);
        }

        Console.WriteLine($"The sum of the digits until it becomes a single-digit number is: {number}");
    }
}
