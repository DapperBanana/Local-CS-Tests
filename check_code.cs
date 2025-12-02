using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is a Lucas-Carmichael number:");
        if (long.TryParse(Console.ReadLine(), out long n))
        {
            bool result = IsLucasCarmichael(n);
            Console.WriteLine($"{n} is {(result ? "" : "not ")}a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static bool IsLucasCarmichael(long n)
    {
        if (n < 2 || !IsCarmichaelNumber(n))
            return false;

        var primeFactors = GetUniquePrimeFactors(n);

        // Check for each prime factor p if p+2 divides n+1
        foreach (var p in primeFactors)
        {
            long pPlus2 = p + 2;
            if ((n + 1) % pPlus2 != 0)
                return false;
        }

        return true;
    }

    static bool IsCarmichaelNumber(long n)
    {
        // Basic check: Carmichael numbers are composite
        if (n < 3 || IsPrime(n))
            return false;

        // Korselt's criterion:
        // n is a Carmichael number iff:
        // 1. n is square-free
        // 2. For every prime divisor p of n, p−1 divides n−1

        var primeFactors = GetUniquePrimeFactors(n);
        if (primeFactors.Any(p => n % p == 0 && IsPrime(p) == false))
        {
            // Already ensured primes, so this check is redundant for prime factors
        }

        if (!IsSquareFree(n))
            return false;

        foreach (var p in primeFactors)
        {
            if ((n - 1) % (p - 1) != 0)
                return false;
        }

        return true;
    }

    static bool IsPrime(long n)
    {
        if (n < 2) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0) return false;

        long sqrtN = (long)Math.Sqrt(n);
        for (long i = 3; i <= sqrtN; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static List<long> GetUniquePrimeFactors(long n)
    {
        var factors = new List<long>();
        long temp = n;

        for (long i = 2; i * i <= temp; i++)
        {
            if (temp % i == 0)
            {
                factors.Add(i);
                while (temp % i == 0)
                {
                    temp /= i;
                }
            }
        }
        if (temp > 1)
            factors.Add(temp);
        return factors.Distinct().ToList();
    }

    static bool IsSquareFree(long n)
    {
        var primeFactors = GetPrimeFactors(n);
        foreach (var p in primeFactors)
        {
            if (n % (p * p) == 0)
                return false;
        }
        return true;
    }

    static List<long> GetPrimeFactors(long n)
    {
        var factors = new List<long>();
        long temp = n;

        for (long i = 2; i <= temp; i++)
        {
            if (i * i > temp)
                break;
            while (temp % i == 0)
            {
                if (!factors.Contains(i))
                    factors.Add(i);
                temp /= i;
            }
        }
        if (temp > 1)
        {
            if (!factors.Contains(temp))
                factors.Add(temp);
        }
        return factors;
    }
}