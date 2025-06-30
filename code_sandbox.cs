
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
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }

        return true;
    }

    static bool IsLucasCarmichael(int n)
    {
        if (IsPrime(n)) return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0 && IsPrime(i) && ((i - 1) | (n - 1)) != 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsLucasCarmichael(number))
        {
            Console.WriteLine(number + " is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine(number + " is not a Lucas-Carmichael number.");
        }
    }
}
