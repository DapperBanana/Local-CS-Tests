
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms in Fibonacci sequence: ");
        int numTerms = int.Parse(Console.ReadLine());

        int firstNum = 0, secondNum = 1, nextNum;

        Console.WriteLine("Fibonacci Sequence:");

        for (int i = 0; i < numTerms; i++)
        {
            if (i <= 1)
            {
                nextNum = i;
            }
            else
            {
                nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;
            }

            Console.Write(nextNum + " ");
        }
    }
}
