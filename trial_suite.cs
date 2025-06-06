
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        Random random = new Random();

        int size = 10;
        char[][] crossword = new char[size][];

        // Initialize crossword puzzle grid with random characters
        for (int i = 0; i < size; i++)
        {
            crossword[i] = new char[size];
            for (int j = 0; j < size; j++)
            {
                crossword[i][j] = (char)random.Next('A', 'Z' + 1);
            }
        }

        // Display the crossword puzzle grid
        Console.WriteLine("Crossword Puzzle:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(crossword[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
