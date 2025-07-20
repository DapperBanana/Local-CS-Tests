
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms in the Fibonacci sequence: ");
        int numOfTerms = int.Parse(Console.ReadLine());

        int firstNum = 0, secondNum = 1, nextNum;

        Console.WriteLine("Fibonacci Sequence:");
        Console.Write(firstNum + ", " + secondNum + ", ");

        for (int i = 2; i < numOfTerms; i++)
        {
            nextNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = nextNum;
            Console.Write(nextNum + ", ");
        }
    }
}
