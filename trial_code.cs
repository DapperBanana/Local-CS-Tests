using System;

class PrimeSumCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the limit:");
        if (int.TryParse(Console.ReadLine(), out int limit))
        {
            long sum = 0;
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Sum of all prime numbers up to {limit} is: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int sqrt = (int)Math.Sqrt(number);
        for (int i = 3; i <= sqrt; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}