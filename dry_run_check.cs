
using System;

class Program
{
    static int ModPow(int x, int y, int p)
    {
        int res = 1;

        x = x % p;

        while (y > 0)
        {
            if ((y % 2) == 1)
                res = (res * x) % p;

            y = y / 2;
            x = (x * x) % p;
        }

        return res;
    }

    static bool IsLucasCarmichael(int n)
    {
        if (n == 2)
            return true;

        for (int a = 2; a < n; a++)
        {
            if (ModPow(a, n - 1, n) != 1)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is a Lucas-Carmichael number:");
        int number = int.Parse(Console.ReadLine());

        if (IsLucasCarmichael(number))
            Console.WriteLine($"{number} is a Lucas-Carmichael number.");
        else
            Console.WriteLine($"{number} is not a Lucas-Carmichael number.");
    }
}
