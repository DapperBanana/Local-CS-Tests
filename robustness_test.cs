
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        Random random = new Random();
        char[,] puzzle = new char[10, 10];

        // Generate random puzzle
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                puzzle[i, j] = (char)('A' + random.Next(26));
            }
        }

        // Print puzzle
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
