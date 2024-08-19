
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfectDigitalInvariant(number))
        {
            Console.WriteLine($"{number} is a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect digital invariant.");
        }
    }

    static bool IsPerfectDigitalInvariant(int num)
    {
        string numStr = num.ToString();
        int sum = 0;

        foreach (char digit in numStr)
        {
            int digitNum = int.Parse(digit.ToString());
            sum += (int)Math.Pow(digitNum, digitNum);
        }

        return sum == num;
    }
}
