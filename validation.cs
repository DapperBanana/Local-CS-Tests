
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static bool IsLucasCarmichael(int number)
    {
        if (!IsPrime(number))
        {
            return false;
        }

        for (int i = 1; i < number; i++)
        {
            int lucasNum = (((int)Math.Pow(1 + Math.Sqrt(5), i) + (int)Math.Pow(1 - Math.Sqrt(5), i)) / (2 * i)) % number;
            if (lucasNum == 0)
            {
                continue;
            }

            int gcd = GCD(number, lucasNum);
            if (gcd != 1)
            {
                return false;
            }
        }

        return true;
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return GCD(b, a % b);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int number = Convert.ToInt32(Console.ReadLine());

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
