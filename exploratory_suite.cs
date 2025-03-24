
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if number is a perfect square
        bool isPerfectSquare = CheckPerfectSquare(number);

        if(isPerfectSquare)
        {
            Console.WriteLine(number + " is a perfect square.");
        }
        else
        {
            Console.WriteLine(number + " is not a perfect square.");
        }
    }

    static bool CheckPerfectSquare(int number)
    {
        int sqrt = (int)Math.Sqrt(number);
        return (sqrt * sqrt == number);
    }
}
