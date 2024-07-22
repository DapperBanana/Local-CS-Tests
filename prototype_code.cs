
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Int32.Parse(Console.ReadLine());

        bool isPerfectSquare = CheckPerfectSquare(number);

        if (isPerfectSquare)
        {
            Console.WriteLine(number + " is a perfect square.");
        }
        else
        {
            Console.WriteLine(number + " is not a perfect square.");
        }
    }

    static bool CheckPerfectSquare(int num)
    {
        int sqrt = (int)Math.Sqrt(num);
        return sqrt * sqrt == num;
    }
}
