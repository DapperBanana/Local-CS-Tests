
using System;

class SudokuValidator
{
    public static bool ValidateSudoku(int[,] grid)
    {
        // Check rows
        for (int i = 0; i < 9; i++)
        {
            bool[] rowCheck = new bool[9];
            for (int j = 0; j < 9; j++)
            {
                if (rowCheck[grid[i, j] - 1])
                {
                    return false;
                }
                rowCheck[grid[i, j] - 1] = true;
            }
        }

        // Check columns
        for (int j = 0; j < 9; j++)
        {
            bool[] colCheck = new bool[9];
            for (int i = 0; i < 9; i++)
            {
                if (colCheck[grid[i, j] - 1])
                {
                    return false;
                }
                colCheck[grid[i, j] - 1] = true;
            }
        }

        // Check grids
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                bool[] gridCheck = new bool[9];
                for (int k = i; k < i+3; k++)
                {
                    for (int l = j; l < j+3; l++)
                    {
                        if (gridCheck[grid[k, l] - 1])
                        {
                            return false;
                        }
                        gridCheck[grid[k, l] - 1] = true;
                    }
                }
            }
        }

        return true;
    }

    public static void Main()
    {
        int[,] sudokuGrid = new int[,] {
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

        if (ValidateSudoku(sudokuGrid))
        {
            Console.WriteLine("Valid Sudoku solution");
        }
        else
        {
            Console.WriteLine("Invalid Sudoku solution");
        }
    }
}
