
using System;

class CrosswordPuzzleGenerator
{
    static void Main()
    {
        Random random = new Random();

        string[] words = { "HELLO", "WORLD", "CROSSWORD", "PUZZLE", "GENERATOR" };

        int gridSize = 10;
        char[,] puzzleGrid = new char[gridSize, gridSize];

        // Fill grid with random letters
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                puzzleGrid[i, j] = (char)(random.Next(26) + 'A');
            }
        }

        // Insert words into grid
        foreach (var word in words)
        {
            int wordLength = word.Length;
            int wordDirection = random.Next(2); // 0 for horizontal, 1 for vertical

            if (wordDirection == 0) // Horizontal
            {
                int startX = random.Next(gridSize - wordLength);
                int startY = random.Next(gridSize);

                for (int i = 0; i < wordLength; i++)
                {
                    puzzleGrid[startY, startX + i] = word[i];
                }
            }
            else // Vertical
            {
                int startX = random.Next(gridSize);
                int startY = random.Next(gridSize - wordLength);

                for (int i = 0; i < wordLength; i++)
                {
                    puzzleGrid[startY + i, startX] = word[i];
                }
            }
        }

        // Print crossword puzzle
        Console.WriteLine("Here is your crossword puzzle:");
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                Console.Write(puzzleGrid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
