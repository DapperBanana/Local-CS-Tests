
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        if (IsPerfectDigitalInvariant(input))
        {
            Console.WriteLine($"{input} is a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine($"{input} is not a perfect digital invariant.");
        }
    }

    static bool IsPerfectDigitalInvariant(string number)
    {
        int sum = 0;

        foreach (char digit in number)
        {
            int num = int.Parse(digit.ToString());
            sum += num;
        }

        int result = int.Parse(number);

        return sum * result == int.Parse(number);
    }
}
