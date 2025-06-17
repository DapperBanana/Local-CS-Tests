
using System;

class LucasCarmichaelNumber
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

    static int Lucas(int n)
    {
        if (n == 0)
            return 2;
        
        if (n == 1)
            return 1;

        return Lucas(n - 1) + Lucas(n - 2);
    }

    static int gcd(int a, int b)
    {
        if (a == 0)
            return b;
        
        return gcd(b % a, a);
    }

    static bool IsLucasCarmichael(int n)
    {
        if (IsPrime(n)) return false;

        for (int i = 1; i <= n; i++)
        {
            if (gcd(n, Lucas(i)) != 1)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsLucasCarmichael(num))
            Console.WriteLine($"{num} is a Lucas-Carmichael number.");
        else
            Console.WriteLine($"{num} is not a Lucas-Carmichael number.");
    }
}
