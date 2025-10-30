
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        // Define the size of the crossword puzzle
        int rows = 10;
        int columns = 10;

        // Define the empty crossword grid
        char[,] puzzle = new char[rows, columns];

        // Generate random letters for the crossword puzzle
        Random rand = new Random();
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                puzzle[row, col] = (char)('A' + rand.Next(26));
            }
        }

        // Display the crossword puzzle
        Console.WriteLine("Crossword Puzzle:");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Console.Write(puzzle[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
