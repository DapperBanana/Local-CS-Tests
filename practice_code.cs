
using System;

class CrosswordGenerator
{
    static void Main()
    {
        // Define the dimensions of the crossword puzzle
        int numRows = 10;
        int numCols = 10;
        
        // Initialize the crossword grid
        char[,] crosswordGrid = new char[numRows, numCols];
        
        // Generate random letters for the crossword grid
        Random random = new Random();
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                crosswordGrid[row, col] = (char)('A' + random.Next(26));
            }
        }
        
        // Display the crossword grid
        Console.WriteLine("Generated Crossword Puzzle:");
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                Console.Write(crosswordGrid[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
