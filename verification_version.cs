
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a limit:");
        int limit = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        
        for (int num = 2; num <= limit; num++)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            
            if (isPrime)
            {
                sum += num;
            }
        }
        
        Console.WriteLine("The sum of all prime numbers up to {0} is: {1}", limit, sum);
    }
}
