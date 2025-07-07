
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        // Size of the crossword puzzle grid
        int gridSize = 10;

        // Create an empty grid of specified size
        char[,] grid = new char[gridSize, gridSize];

        // Fill the grid with random letters
        Random random = new Random();
        for (int row = 0; row < gridSize; row++)
        {
            for (int col = 0; col < gridSize; col++)
            {
                grid[row, col] = (char)('A' + random.Next(26));
            }
        }

        // Print the crossword puzzle grid
        for (int row = 0; row < gridSize; row++)
        {
            for (int col = 0; col < gridSize; col++)
            {
                Console.Write(grid[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
