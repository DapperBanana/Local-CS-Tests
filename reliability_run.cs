
using System;

class Program
{
    public static bool IsPrime(int num)
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

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int nextPrime = num + 1;
        while (true)
        {
            if (IsPrime(nextPrime))
            {
                Console.WriteLine($"The smallest prime number greater than {num} is {nextPrime}");
                break;
            }
            nextPrime++;
        }
    }
}
