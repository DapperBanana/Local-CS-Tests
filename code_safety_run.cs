
using System;

class LucasCarmichael
{
    static bool IsLucasCarmichael(int n)
    {
        if (IsPrime(n))
        {
            return false;
        }

        int a = 2;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            int c = a + b;
            a = b;
            b = c;
            if (b % n == 0 && b % n != 0)
            {
                return false;
            }
        }

        return b % n == 2;
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        if (number == 2)
        {
            return true;
        }
        if (number % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
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

