
using System;

class Program
{
    static void Main()
    {
        int number;
        
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        
        bool isPerfectSquare = CheckPerfectSquare(number);
        
        if (isPerfectSquare)
        {
            Console.WriteLine($"{number} is a perfect square.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect square.");
        }
    }
    
    static bool CheckPerfectSquare(int num)
    {
        double squareRoot = Math.Sqrt(num);
        return (squareRoot - Math.Floor(squareRoot)) == 0;
    }
}
