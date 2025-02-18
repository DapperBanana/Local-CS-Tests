
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
        if (n == 0)
            return 2;
        if (n == 1)
            return 1;

        return Lucas(n - 1) + Lucas(n - 2);
    }

    static bool IsLucasCarmichaelNumber(int n)
    {
        if (!IsPrime(n))
            return false;

        int k = 1;
        while (Lucas(k) % n != 0)
        {
            k++;
        }

        return k == n - 1;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsLucasCarmichaelNumber(num))
        {
            Console.WriteLine(num + " is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine(num + " is not a Lucas-Carmichael number.");
        }
    }
}
