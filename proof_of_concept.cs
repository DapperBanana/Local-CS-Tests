
using System;

class CrosswordPuzzleGenerator
{
    static Random random = new Random();

    static void Main()
    {
        int rows = 10;
        int cols = 10;
        char[,] puzzle = new char[rows, cols];

        // Fill the puzzle with random letters
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                puzzle[r, c] = (char)random.Next('A', 'Z' + 1);
            }
        }

        // Display the puzzle
        Console.WriteLine("Crossword Puzzle:");
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write(puzzle[r, c] + " ");
            }
            Console.WriteLine();
        }
    }
}

