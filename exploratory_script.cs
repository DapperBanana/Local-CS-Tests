
using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static int Jacobi(int a, int n)
    {
        if (a == 0) return 0;
        if (a == 1) return 1;

        if (a % 2 == 0)
        {
            return Jacobi(a / 2, n) * Math.Pow(-1, ((n * n - 1) / 8));
        }
        else
        {
            return Jacobi(n % a, a) * Math.Pow(-1, ((a - 1) * (n - 1) / 4));
        }
    }

    static bool IsLucasCarmichaelNumber(int n)
    {
        if (!IsPrime(n)) return false;

        int p = 2;
        while (p < 100)
        {
            if (n % (int)Math.Pow(p, 2) == 0) return false;
            if (Jacobi(p, n) != 1) return false;
            p++;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsLucasCarmichaelNumber(number))
        {
            Console.WriteLine(number + " is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine(number + " is not a Lucas-Carmichael number.");
        }
    }
}
