
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());

        int firstNumber = 0;
        int secondNumber = 1;
        int nextNumber;

        Console.WriteLine("Fibonacci sequence:");
        for (int i = 0; i < numberOfTerms; i++)
        {
            if (i <= 1)
            {
                nextNumber = i;
            }
            else
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            Console.Write(nextNumber + " ");
        }
    }
}
