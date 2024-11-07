
using System;

class Program
{
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return GCD(b, a % b);
    }

    static int ModPow(int a, int n, int m)
    {
        int result = 1;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                result = (result * a) % m;
            }
            a = (a * a) % m;
            n /= 2;
        }
        return result;
    }

    static bool IsCarmichael(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int a = 2; a < n; a++)
        {
            if (GCD(a, n) == 1)
            {
                if (ModPow(a, n, n) != a)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it's a Carmichael number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsCarmichael(number))
        {
            Console.WriteLine($"{number} is a Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Carmichael number.");
        }
    }
}
