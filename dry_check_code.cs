using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer (n): ");
        int n;
        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            int sum = (n * (n + 1)) / 2; // Formula for the sum of first n natural numbers
            Console.WriteLine($"Sum of the first {n} natural numbers is: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}