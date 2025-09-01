
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = CalculateSumOfDigits(number);

        while (sum > 9)
        {
            sum = CalculateSumOfDigits(sum);
        }

        Console.WriteLine("Single digit sum: " + sum);
    }

    static int CalculateSumOfDigits(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
}
