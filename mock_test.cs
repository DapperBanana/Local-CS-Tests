
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        if (IsPerfectSquare(number))
        {
            Console.WriteLine("{0} is a perfect square.", number);
        }
        else
        {
            Console.WriteLine("{0} is not a perfect square.", number);
        }
    }

    static bool IsPerfectSquare(int number)
    {
        if (number < 0)
        {
            return false;
        }

        int sqrt = (int)Math.Sqrt(number);
        return (sqrt * sqrt == number);
    }
}
