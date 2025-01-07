
using System;

class MainClass {
    public static void Main (string[] args) {
        int input;

        Console.Write("Enter a number: ");
        input = Convert.ToInt32(Console.ReadLine());

        int result = FindNextPrime(input);

        Console.WriteLine($"The smallest prime number greater than {input} is: {result}");
    }

    public static int FindNextPrime(int number)
    {
        number++;
        while (true)
        {
            if (IsPrime(number))
            {
                return number;
            }
            number++;
        }
    }

    public static bool IsPrime(int number)
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
}
