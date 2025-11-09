
using System;

class Program
{
    static bool IsCarmichael(int num)
    {
        if (num < 2)
            return false;

        for (int a = 2; a < num; a++)
        {
            if (GCD(a, num) == 1 && FastExp(a, num - 1, num) != 1)
                return false;
        }

        return true;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int FastExp(int x, int n, int mod)
    {
        if (n == 0)
            return 1;

        long result = 1;
        long power = x;

        while (n > 0)
        {
            if (n % 2 == 1)
            {
                result = (result * power) % mod;
            }

            power = (power * power) % mod;
            n = n / 2;
        }

        return (int)result;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Carmichael number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsCarmichael(num))
            Console.WriteLine($"{num} is a Carmichael number.");
        else
            Console.WriteLine($"{num} is not a Carmichael number.");
    }
}
