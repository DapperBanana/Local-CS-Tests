
using System;

class PrimeFactors
{
    public static void FindPrimeFactors(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.WriteLine(i + " ");
                n = n / i;
            }
        }

        if (n > 2)
        {
            Console.WriteLine(n);
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prime factors of " + number + " are:");
        FindPrimeFactors(number);
    }
}
