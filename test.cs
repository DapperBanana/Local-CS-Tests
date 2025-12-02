using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            bool isLucasCarmichael = IsLucasCarmichael(number);
            Console.WriteLine($"{number} is {(isLucasCarmichael ? "" : "not ")}a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    static bool IsLucasCarmichael(int n)
    {
        if (n < 2 || !IsPrime(n))
            return false;
        
        var primeFactors = GetPrimeFactors(n);
        foreach (var p in primeFactors)
        {
            int q = n - p + 1;
            if (q <= 1 || !IsPrime(q))
                return false;
        }
        return true;
    }

    static List<int> GetPrimeFactors(int n)
    {
        var factors = new List<int>();
        int number = n;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            while (number % i == 0)
            {
                if (!factors.Contains(i))
                    factors.Add(i);
                number /= i;
            }
        }
        if (number > 1 && !factors.Contains(number))
            factors.Add(number);

        return factors;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }
        return true;
    }
}