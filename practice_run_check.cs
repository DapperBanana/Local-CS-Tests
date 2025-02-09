
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

    static bool IsPerfectDigitalInvariant(int number)
    {
        string numberStr = number.ToString();
        int sum = 0;

        for (int i = 0; i < numberStr.Length; i++)
        {
            int digit = int.Parse(numberStr[i].ToString());
            sum += digit * digit;
        }

        return sum == number;
    }
}
