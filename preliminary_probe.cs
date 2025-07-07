
using System;

class Program
{
    static bool IsLucasCarmichael(int n)
    {
        if (IsComposite(n))
        {
            for (int a = 2; a < n; a++)
            {
                if (ModPow(a, n - 1, n) != 1)
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }

    static bool IsComposite(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return true;
        }
        return false;
    }

    static int ModPow(int x, int y, int p)
    {
        int res = 1;
        x = x % p;
        while (y > 0)
        {
            if (y % 2 == 1)
                res = (res * x) % p;
            y = y >> 1;
            x = (x * x) % p;
        }
        return res;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsLucasCarmichael(number))
        {
            Console.WriteLine($"{number} is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Lucas-Carmichael number.");
        }
    }
}
