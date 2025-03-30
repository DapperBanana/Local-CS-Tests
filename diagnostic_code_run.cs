
using System;

class PrimeFactors
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prime factors of {number} are:");
        FindPrimeFactors(number);
    }

    static void FindPrimeFactors(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.WriteLine(i);
                n = n / i;
            }
        }
    }
}
