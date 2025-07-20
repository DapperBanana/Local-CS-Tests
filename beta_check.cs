
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static int FindNextPrime(int num)
    {
        int nextNum = num + 1;
        while (true)
        {
            if (IsPrime(nextNum))
                return nextNum;
            nextNum++;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int nextPrime = FindNextPrime(num);
        Console.WriteLine($"The smallest prime number greater than {num} is {nextPrime}");
    }
}
