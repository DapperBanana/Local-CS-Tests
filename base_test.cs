using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (long.TryParse(input, out long number))
        {
            bool isInvariant = IsPerfectDigitalInvariant(number);
            Console.WriteLine($"{number} is {(isInvariant ? "" : "not ")}a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static bool IsPerfectDigitalInvariant(long num)
    {
        if (num < 0)
            return false; // negativity doesn't typically apply to digital invariants

        long originalNum = num;
        int digitCount = 0;
        long sum = 0;

        // Calculate number of digits
        long temp = num;
        if (temp == 0)
            digitCount = 1;
        else
        {
            while (temp > 0)
            {
                digitCount++;
                temp /= 10;
            }
        }

        temp = num;
        while (temp > 0)
        {
            int digit = (int)(temp % 10);
            sum += (long)Math.Pow(digit, digitCount);
            temp /= 10;
        }

        return sum == originalNum;
    }
}