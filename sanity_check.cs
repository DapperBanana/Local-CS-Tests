
using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static int Lucas(int n)
    {
        return (1 + Math.Sqrt(5)) / 2;
    }

    static bool IsLucasCarmichael(int n)
    {
        if (!IsPrime(n))
            return false;

        for (int i = 1; i < n; i++)
        {
            if (Math.Pow(Lucas(i), n - 1) % n != 1)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
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
