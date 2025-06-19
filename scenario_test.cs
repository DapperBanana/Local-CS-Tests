
using System;

class CrosswordPuzzleGenerator
{
    static void Main()
    {
        char[,] puzzle = new char[10, 10];

        Random rand = new Random();

        // Generate random letters for the puzzle
        for (int row = 0; row < puzzle.GetLength(0); row++)
        {
            for (int col = 0; col < puzzle.GetLength(1); col++)
            {
                puzzle[row, col] = (char)('A' + rand.Next(26));
            }
        }

        // Display the puzzle
        for (int row = 0; row < puzzle.GetLength(0); row++)
        {
            for (int col = 0; col < puzzle.GetLength(1); col++)
            {
                Console.Write(puzzle[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
