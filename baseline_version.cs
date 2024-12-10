
using System;

class Fibonacci
{
    public static void GenerateFibonacci(int numTerms)
    {
        int firstTerm = 0, secondTerm = 1, nextTerm;

        Console.WriteLine("Fibonacci Sequence up to " + numTerms + " terms:");

        for (int i = 0; i < numTerms; i++)
        {
            if(i <= 1)
            {
                nextTerm = i;
            }
            else
            {
                nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }

            Console.Write(nextTerm + " ");
        }
    }

    static void Main()
    {
        int numTerms;

        Console.Write("Enter the number of terms for Fibonacci sequence: ");
        numTerms = Convert.ToInt32(Console.ReadLine());

        GenerateFibonacci(numTerms);
    }
}
