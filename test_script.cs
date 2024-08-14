
using System;

class Program
{
    static void Main()
    {
        int n;
        
        Console.Write("Enter a number to check if it is a Carmichael number: ");
        n = int.Parse(Console.ReadLine());

        if (IsCarmichael(n))
        {
            Console.WriteLine($"{n} is a Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{n} is not a Carmichael number.");
        }
    }

    static bool IsCarmichael(int n)
    {
        if (n < 3 || n % 2 == 0)
        {
            return false;
        }

        for (int a = 2; a < n; a++)
        {
            if (Gcd(a, n) != 1 || ModExp(a, n - 1, n) != 1)
            {
                return false;
            }
        }

        return true;
    }

    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int ModExp(int x, int y, int p)
    {
        int result = 1;
        x = x % p;

        while (y > 0)
        {
            if (y % 2 == 1)
            {
                result = (result * x) % p;
            }

            y = y >> 1;
            x = (x * x) % p;
        }

        return result;
    }
}
