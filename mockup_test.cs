
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

    static bool IsLucasCarmichael(int n)
    {
        if (!IsPrime(n))
        {
            return false;
        }

        for (int i = 1; i < n; i++)
        {
            if ((Math.Pow(i, n - 1) - 1) % n != 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsLucasCarmichael(num))
        {
            Console.WriteLine(num + " is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine(num + " is not a Lucas-Carmichael number.");
        }
    }
}
