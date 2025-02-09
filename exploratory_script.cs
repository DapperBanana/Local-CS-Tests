
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

        Console.WriteLine("Sum of digits until it becomes a single-digit number: " + sum);
    }

    static int CalculateSumOfDigits(int num)
    {
        int sum = 0;
        while(num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
