
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        // Define the dimensions of the crossword puzzle
        int rows = 10;
        int cols = 10;

        // Create a 2D array to store the characters of the puzzle
        char[,] puzzle = new char[rows, cols];

        // Generate random letters for each cell in the puzzle
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                puzzle[i, j] = (char)rnd.Next('A', 'Z' + 1);
            }
        }

        // Output the crossword puzzle
        Console.WriteLine("Crossword Puzzle:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(puzzle[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
