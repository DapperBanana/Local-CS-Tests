
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsHarshadNumber(number))
        {
            Console.WriteLine("{0} is a Harshad (Niven) number.", number);
        }
        else
        {
            Console.WriteLine("{0} is not a Harshad (Niven) number.", number);
        }
    }

    static bool IsHarshadNumber(int number)
    {
        int sum = 0;
        int originalNumber = number;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return originalNumber % sum == 0;
    }
}

