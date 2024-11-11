
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

    static int Napier(int n)
    {
        double SqrtFive = Math.Sqrt(5);
        double Phi = (1 + SqrtFive) / 2;
        double phi = (1 - SqrtFive) / 2;

        return (int)Math.Round((Math.Pow(Phi, n) - Math.Pow(phi, n)) / SqrtFive);
    }

    static bool IsLucasCarmichael(int n)
    {
        if (!IsPrime(n))
            return false;

        if (Napier(n) % n == 0)
            return true;
        else
            return false;
    }

    static void Main()
    {
        int num;

        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        num = int.Parse(Console.ReadLine());

        if (IsLucasCarmichael(num))
            Console.WriteLine($"{num} is a Lucas-Carmichael number.");
        else
            Console.WriteLine($"{num} is not a Lucas-Carmichael number.");
    }
}
