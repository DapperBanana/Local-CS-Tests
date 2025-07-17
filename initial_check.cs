
using System;

class Program
{
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

    static int Power(int a, int n, int p)
    {
        int res = 1;
        a = a % p;

        while (n > 0)
        {
            if (n % 2 == 1)
                res = (res * a) % p;

            n = n / 2;
            a = (a * a) % p;
        }

        return res;
    }

    static bool IsLucasCarmichael(int n)
    {
        if (IsPrime(n)) return false;

        for (int i = 2; i < n; i++)
        {
            if (Power(i, n - 1, n) != 1)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int number;

        Console.WriteLine("Enter a number to check if it is a Lucas-Carmichael number: ");
        number = Convert.ToInt32(Console.ReadLine());

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
