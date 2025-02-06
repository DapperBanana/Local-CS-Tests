
using System;

class Program
{
    static void Main()
    {
        int num;
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out num))
        {
            if (IsLucasCarmichael(num))
            {
                Console.WriteLine($"{num} is a Lucas-Carmichael number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a Lucas-Carmichael number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer number.");
        }
    }

    static bool IsLucasCarmichael(int num)
    {
        if (num <= 1)
            return false;

        for (int a = 2; a < num; a++)
        {
            if (num % a == 0)
            {
                if (IsPrime(a))
                {
                    int m = num / a;
                    if (LucasLehmerPrime(m))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static bool LucasLehmerPrime(int p)
    {
        long s = 4;
        for (int i = 0; i < p - 2; i++)
        {
            s = (s * s - 2) % (p * p);
        }

        return s == 0;
    }
}
