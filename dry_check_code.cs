
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        Random random = new Random();

        // Define the crossword grid size
        int gridSize = 10;

        // Create a 2D array to store the crossword grid
        char[,] grid = new char[gridSize, gridSize];

        // Fill the grid with random letters
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                grid[i, j] = (char)('A' + random.Next(26));
            }
        }

        // Display the crossword grid
        Console.WriteLine("Crossword Puzzle:");
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
