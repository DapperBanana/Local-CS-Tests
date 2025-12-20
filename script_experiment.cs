using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        int sum = 0;
        foreach (char digit in input)
        {
            if (char.IsDigit(digit))
            {
                sum += digit - '0';
            }
        }

        Console.WriteLine($"Sum of digits: {sum}");
    }
}