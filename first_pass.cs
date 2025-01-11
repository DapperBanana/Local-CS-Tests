
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int givenNumber = int.Parse(Console.ReadLine());

        int primeNumber = givenNumber + 1;
        while (true)
        {
            if (IsPrime(primeNumber))
            {
                Console.WriteLine($"The smallest prime number greater than {givenNumber} is: {primeNumber}");
                break;
            }
            primeNumber++;
        }
    }
}
