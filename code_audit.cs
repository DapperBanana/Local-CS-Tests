
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
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
        int input = Convert.ToInt32(Console.ReadLine());

        int currentNumber = input + 1;

        while (true)
        {
            if (IsPrime(currentNumber))
            {
                Console.WriteLine("The smallest prime number greater than {0} is: {1}", input, currentNumber);
                break;
            }
            currentNumber++;
        }
    }
}
