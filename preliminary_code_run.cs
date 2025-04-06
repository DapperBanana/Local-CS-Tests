
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2 || num == 3) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0) return false;
        }

        return true;
    }

    static int NextPrime(int num)
    {
        num++;

        while (!IsPrime(num))
        {
            num++;
        }

        return num;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        int result = NextPrime(input);
        Console.WriteLine($"The smallest prime number greater than {input} is: {result}");
    }
}
