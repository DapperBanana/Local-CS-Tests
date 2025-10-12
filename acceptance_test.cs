
using System;

class Program
{
    static void Main()
    {
        int[,] sudoku = {
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

        bool isValid = ValidateSudoku(sudoku);

        if (isValid)
        {
            Console.WriteLine("Sudoku solution is valid.");
        }
        else
        {
            Console.WriteLine("Sudoku solution is invalid.");
        }
    }

    static bool ValidateSudoku(int[,] sudoku)
    {
        for (int i = 0; i < 9; i++)
        {
            if (!ValidateRow(sudoku, i) || !ValidateColumn(sudoku, i) || !ValidateBox(sudoku, i))
            {
                return false;
            }
        }
        return true;
    }

    static bool ValidateRow(int[,] sudoku, int row)
    {
        bool[] used = new bool[9];

        for (int i = 0; i < 9; i++)
        {
            int num = sudoku[row, i] - 1;
            if (used[num])
            {
                return false;
            }
            used[num] = true;
        }

        return true;
    }

    static bool ValidateColumn(int[,] sudoku, int col)
    {
        bool[] used = new bool[9];

        for (int i = 0; i < 9; i++)
        {
            int num = sudoku[i, col] - 1;
            if (used[num])
            {
                return false;
            }
            used[num] = true;
        }

        return true;
    }

    static bool ValidateBox(int[,] sudoku, int box)
    {
        bool[] used = new bool[9];

        int startRow = (box / 3) * 3;
        int startCol = (box % 3) * 3;

        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                int num = sudoku[i, j] - 1;
                if (used[num])
                {
                    return false;
                }
                used[num] = true;
            }
        }

        return true;
    }
}
