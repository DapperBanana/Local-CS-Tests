
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static int NextPrime(int number)
    {
        int nextNumber = number + 1;

        while (true)
        {
            if (IsPrime(nextNumber))
            {
                return nextNumber;
            }

            nextNumber++;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        int nextPrime = NextPrime(userInput);

        Console.WriteLine($"The smallest prime number greater than {userInput} is: {nextPrime}");
    }
}
