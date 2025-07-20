
using System;

class Program
{
    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int FindNextPrime(int num)
    {
        int nextNum = num + 1;

        while (true)
        {
            if (IsPrime(nextNum))
            {
                return nextNum;
            }
            nextNum++;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = FindNextPrime(number);
        Console.WriteLine($"The smallest prime number greater than {number} is: {result}");
    }
}
