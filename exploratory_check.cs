
using System;

class Program
{
    static void Main()
    {
        int[,] sudoku = new int[9, 9]
        {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9}
        };

        if (ValidateSudoku(sudoku))
        {
            Console.WriteLine("Valid Sudoku Solution");
        }
        else
        {
            Console.WriteLine("Invalid Sudoku Solution");
        }
    }

    static bool ValidateSudoku(int[,] puzzle)
    {
        for (int i = 0; i < 9; i++)
        {
            if (!IsRowValid(puzzle, i) || !IsColumnValid(puzzle, i) || !IsSquareValid(puzzle, i))
            {
                return false;
            }
        }

        return true;
    }

    static bool IsRowValid(int[,] puzzle, int row)
    {
        bool[] seen = new bool[9];
        for (int i = 0; i < 9; i++)
        {
            int num = puzzle[row, i];
            if (num != 0 && seen[num - 1])
            {
                return false;
            }
            seen[num - 1] = true;
        }
        return true;
    }

    static bool IsColumnValid(int[,] puzzle, int col)
    {
        bool[] seen = new bool[9];
        for (int i = 0; i < 9; i++)
        {
            int num = puzzle[i, col];
            if (num != 0 && seen[num - 1])
            {
                return false;
            }
            seen[num - 1] = true;
        }
        return true;
    }

    static bool IsSquareValid(int[,] puzzle, int index)
    {
        int startX = (index % 3) * 3;
        int startY = (index / 3) * 3;
        bool[] seen = new bool[9];
        for (int i = startY; i < startY + 3; i++)
        {
            for (int j = startX; j < startX + 3; j++)
            {
                int num = puzzle[i, j];
                if (num != 0 && seen[num - 1])
                {
                    return false;
                }
                seen[num - 1] = true;
            }
        }
        return true;
    }
}
