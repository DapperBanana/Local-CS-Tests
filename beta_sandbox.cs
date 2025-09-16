
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        Random random = new Random();

        // Create a grid for the crossword puzzle
        char[,] puzzleGrid = new char[10, 10];

        // Generate random letters for the grid
        for (int i = 0; i < puzzleGrid.GetLength(0); i++)
        {
            for (int j = 0; j < puzzleGrid.GetLength(1); j++)
            {
                puzzleGrid[i, j] = (char)random.Next('A', 'Z' + 1);
            }
        }

        // Display the crossword puzzle grid
        for (int i = 0; i < puzzleGrid.GetLength(0); i++)
        {
            for (int j = 0; j < puzzleGrid.GetLength(1); j++)
            {
                Console.Write(puzzleGrid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
