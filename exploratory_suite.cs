
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        Random rnd = new Random();
        char[,] puzzle = new char[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                puzzle[i, j] = (char)('A' + rnd.Next(26));
            }
        }

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
