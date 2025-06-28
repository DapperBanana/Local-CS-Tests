
using System;

class Program
{
    static void Main()
    {
        int inputNumber;
        Console.Write("Enter a number: ");
        inputNumber = Convert.ToInt32(Console.ReadLine());

        int nextPrime = FindNextPrime(inputNumber);

        Console.WriteLine($"The smallest prime number greater than {inputNumber} is: {nextPrime}");

    }

    static int FindNextPrime(int num)
    {
        num++;
        while (true)
        {
            if (IsPrime(num))
            {
                return num;
            }
            num++;
        }
    }

    static bool IsPrime(int num)
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
}
