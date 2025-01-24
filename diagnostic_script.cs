
using System;

class SudokuValidator
{
    static bool IsValidSudoku(int[,] sudoku)
    {
        // Check each row
        for (int i = 0; i < 9; i++)
        {
            bool[] rowValues = new bool[9];
            for (int j = 0; j < 9; j++)
            {
                if (sudoku[i, j] != 0)
                {
                    if (rowValues[sudoku[i, j] - 1])
                    {
                        return false;
                    }
                    rowValues[sudoku[i, j] - 1] = true;
                }
            }
        }

        // Check each column
        for (int j = 0; j < 9; j++)
        {
            bool[] colValues = new bool[9];
            for (int i = 0; i < 9; i++)
            {
                if (sudoku[i, j] != 0)
                {
                    if (colValues[sudoku[i, j] - 1])
                    {
                        return false;
                    }
                    colValues[sudoku[i, j] - 1] = true;
                }
            }
        }

        // Check each 3x3 subgrid
        for (int block = 0; block < 9; block++)
        {
            bool[] gridValues = new bool[9];
            for (int i = block / 3 * 3; i < block / 3 * 3 + 3; i++)
            {
                for (int j = block % 3 * 3; j < block % 3 * 3 + 3; j++)
                {
                    if (sudoku[i, j] != 0)
                    {
                        if (gridValues[sudoku[i, j] - 1])
                        {
                            return false;
                        }
                        gridValues[sudoku[i, j] - 1] = true;
                    }
                }
            }
        }

        return true;
    }

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

        if (IsValidSudoku(sudoku))
        {
            Console.WriteLine("Valid Sudoku solution.");
        }
        else
        {
            Console.WriteLine("Invalid Sudoku solution.");
        }
    }
}
