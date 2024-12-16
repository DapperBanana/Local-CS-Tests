
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        char[,] puzzle = new char[10, 10];

        Random rand = new Random();

        // Generate random letters for the puzzle
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                puzzle[i, j] = (char)rand.Next(65, 91);
            }
        }

        // Print out the crossword puzzle
        Console.WriteLine("Crossword Puzzle:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(puzzle[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
