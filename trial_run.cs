
using System;

class Program
{
    public static long ModPow(long x, long y, long p)
    {
        long res = 1;
        x = x % p;
        
        while (y > 0)
        {
            if (y % 2 == 1)
            {
                res = (res * x) % p;
            }
            y = y >> 1;
            x = (x * x) % p;
        }
        
        return res;
    }

    public static bool IsPrime(long n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;

        if (n % 2 == 0 || n % 3 == 0) return false;

        for (long i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }

        return true;
    }
    
    public static bool IsLucasCarmichaelNumber(long n)
    {
        if (IsPrime(n)) return false;

        for (long i = 2; i <= n / 2; i++)
        {
            if (n % i == 0 && IsPrime(i) && ModPow(2, n - 1, i) != 1)
            {
                return false;
            }
        }
        
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        long number = long.Parse(Console.ReadLine());
        
        if (IsLucasCarmichaelNumber(number))
        {
            Console.WriteLine(number + " is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine(number + " is not a Lucas-Carmichael number.");
        }
    }
}
