
using System;

class CrosswordPuzzle
{
    static Random random = new Random();

    static void Main()
    {
        string[] words = { "BEAR", "TIGER", "LION", "ELEPHANT", "ZEBRA" };
        char[,] puzzle = GeneratePuzzle(words);

        Console.WriteLine("Crossword Puzzle:");
        PrintPuzzle(puzzle);
    }

    static char[,] GeneratePuzzle(string[] words)
    {
        int gridSize = 10;
        char[,] puzzle = new char[gridSize, gridSize];

        foreach (string word in words)
        {
            int direction = random.Next(2); // 0 for horizontal, 1 for vertical
            int row = random.Next(gridSize);
            int col = random.Next(gridSize);

            bool fits = CheckFit(puzzle, word, direction, row, col);
            while (!fits)
            {
                direction = random.Next(2);
                row = random.Next(gridSize);
                col = random.Next(gridSize);
                fits = CheckFit(puzzle, word, direction, row, col);
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (direction == 0)
                {
                    puzzle[row, col + i] = word[i];
                }
                else
                {
                    puzzle[row + i, col] = word[i];
                }
            }
        }

        FillBlanks(puzzle);

        return puzzle;
    }

    static bool CheckFit(char[,] puzzle, string word, int direction, int row, int col)
    {
        if (direction == 0 && col + word.Length > puzzle.GetLength(1))
        {
            return false;
        }

        if (direction == 1 && row + word.Length > puzzle.GetLength(0))
        {
            return false;
        }

        for (int i = 0; i < word.Length; i++)
        {
            char c = (direction == 0) ? puzzle[row, col + i] : puzzle[row + i, col];
            if (c != '\0' && c != word[i])
            {
                return false;
            }
        }

        return true;
    }

    static void FillBlanks(char[,] puzzle)
    {
        for (int row = 0; row < puzzle.GetLength(0); row++)
        {
            for (int col = 0; col < puzzle.GetLength(1); col++)
            {
                if (puzzle[row, col] == '\0')
                {
                    puzzle[row, col] = (char)('A' + random.Next(26));
                }
            }
        }
    }

    static void PrintPuzzle(char[,] puzzle)
    {
        for (int row = 0; row < puzzle.GetLength(0); row++)
        {
            for (int col = 0; col < puzzle.GetLength(1); col++)
            {
                Console.Write(puzzle[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
