
using System;

class Program
{
    static void Main()
    {
        int num;
        Console.Write("Enter a number to check if it is prime: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num))
        {
            Console.WriteLine(num + " is a prime number.");
        }
        else
        {
            Console.WriteLine(num + " is not a prime number.");
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        if (num == 2)
            return true;
        if (num % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
