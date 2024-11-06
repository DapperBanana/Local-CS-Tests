
using System;

class CrosswordPuzzleGenerator
{
    static char[,] GenerateCrossword(int rows, int cols)
    {
        char[,] crossword = new char[rows, cols];
        Random random = new Random();

        // Fill the crossword grid with random characters
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                crossword[i, j] = (char)('A' + random.Next(26));
            }
        }

        return crossword;
    }

    static void PrintCrossword(char[,] crossword)
    {
        for (int i = 0; i < crossword.GetLength(0); i++)
        {
            for (int j = 0; j < crossword.GetLength(1); j++)
            {
                Console.Write(crossword[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int rows = 10;
        int cols = 10;

        char[,] crossword = GenerateCrossword(rows, cols);
        PrintCrossword(crossword);
    }
}
