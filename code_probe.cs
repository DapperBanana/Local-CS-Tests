
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsNarcissistic(num))
        {
            Console.WriteLine($"{num} is a narcissistic number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a narcissistic number.");
        }
    }

    static bool IsNarcissistic(int num)
    {
        int originalNum = num;
        int numDigits = (int)Math.Floor(Math.Log10(num)) + 1;

        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, numDigits);
            num /= 10;
        }

        return sum == originalNum;
    }
}
