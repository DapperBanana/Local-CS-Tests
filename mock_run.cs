
using System;

class Program
{
    static bool IsCarmichael(int n)
    {
        if (IsPrime(n))
        {
            return false;
        }

        for (int a = 2; a < n; a++)
        {
            if (GCD(a, n) == 1 && ModPow(a, n - 1, n) != 1)
            {
                return false;
            }
        }

        return true;
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    static int ModPow(int x, int y, int p)
    {
        int res = 1;
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

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Carmichael number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsCarmichael(num))
        {
            Console.WriteLine($"{num} is a Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a Carmichael number.");
        }
    }
}
