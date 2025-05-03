
using System;

public class PrimeFactorsProgram
{
    public static void Main()
    {
        Console.Write("Enter a number to find its prime factors: ");
        int num = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Prime factors of " + num + " are:");
        FindPrimeFactors(num);
    }

    public static void FindPrimeFactors(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.WriteLine(i);
                n /= i;
            }
        }

        if (n > 1)
        {
            Console.WriteLine(n);
        }
    }
}
