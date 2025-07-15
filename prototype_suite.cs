
using System;

class PrimeFactors
{
    static void FindPrimeFactors(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.Write(i + " ");
                n /= i;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number to find its prime factors: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Prime factors of " + num + " are: ");
        FindPrimeFactors(num);
    }
}
