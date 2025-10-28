
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        char[,] puzzle = new char[10, 10];

        Random rnd = new Random();

        // Fill in the puzzle with random characters
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                puzzle[i, j] = (char)rnd.Next(65, 91); // Random uppercase letter
            }
        }

        // Display the crossword puzzle
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
