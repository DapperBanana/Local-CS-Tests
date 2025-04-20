
using System;

class Program
{
    static void Main()
    {
        // Define the dimensions of the crossword puzzle
        int rows = 10;
        int cols = 10;

        // Initialize the crossword grid
        char[,] crossword = new char[rows, cols];

        // Generate random letters for the crossword puzzle
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                crossword[i, j] = (char)rnd.Next('A', 'Z' + 1);
            }
        }

        // Print the crossword puzzle grid
        Console.WriteLine("Crossword Puzzle:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(crossword[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
