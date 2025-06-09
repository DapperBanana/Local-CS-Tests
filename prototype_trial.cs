
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the range to calculate the sum of prime numbers: \nFrom: ");
        int start = int.Parse(Console.ReadLine());
        
        Console.Write("To: ");
        int end = int.Parse(Console.ReadLine());

        long sum = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine($"The sum of prime numbers in the range ({start}-{end}) is: {sum}");
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
