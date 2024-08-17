
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        char[,] puzzle = GeneratePuzzle(10, 10);

        Console.WriteLine("Crossword Puzzle:");
        for (int i = 0; i < puzzle.GetLength(0); i++)
        {
            for (int j = 0; j < puzzle.GetLength(1); j++)
            {
                Console.Write(puzzle[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static char[,] GeneratePuzzle(int rows, int cols)
    {
        char[,] puzzle = new char[rows, cols];
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (rand.Next(2) == 0) // 50% chance of generating a letter
                {
                    puzzle[i, j] = (char)('A' + rand.Next(26)); // Random uppercase letter
                }
                else
                {
                    puzzle[i, j] = ' ';
                }
            }
        }

        return puzzle;
    }
}
