
using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static int Power(int x, int y, int p)
    {
        int res = 1;
        x = x % p;
        for (int i = 0; i < y; i++)
        {
            res = (res * x) % p;
        }
        return res;
    }

    static bool IsCarmichaelNumber(int n)
    {
        if (IsPrime(n))
        {
            return false;
        }

        for (int a = 2; a < n; a++)
        {
            if (Power(a, n, n) != a)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Carmichael number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsCarmichaelNumber(number))
        {
            Console.WriteLine($"{number} is a Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Carmichael number.");
        }
    }
}
