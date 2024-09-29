
using System;

class SudokuValidator
{
    static bool IsValidSolution(int[,] sudoku)
    {
        // Validate rows
        for (int i = 0; i < 9; i++)
        {
            int[] row = new int[10];
            for (int j = 0; j < 9; j++)
            {
                if (sudoku[i, j] < 1 || sudoku[i, j] > 9 || row[sudoku[i, j]] == 1)
                {
                    return false;
                }
                row[sudoku[i, j]] = 1;
            }
        }

        // Validate columns
        for (int i = 0; i < 9; i++)
        {
            int[] col = new int[10];
            for (int j = 0; j < 9; j++)
            {
                if (sudoku[j, i] < 1 || sudoku[j, i] > 9 || col[sudoku[j, i]] == 1)
                {
                    return false;
                }
                col[sudoku[j, i]] = 1;
            }
        }

        // Validate subgrids
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                int[] grid = new int[10];
                for (int x = i; x < i + 3; x++)
                {
                    for (int y = j; y < j + 3; y++)
                    {
                        if (sudoku[x, y] < 1 || sudoku[x, y] > 9 || grid[sudoku[x, y]] == 1)
                        {
                            return false;
                        }
                        grid[sudoku[x, y]] = 1;
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

        if (IsValidSolution(sudoku))
        {
            Console.WriteLine("The Sudoku solution is valid.");
        }
        else
        {
            Console.WriteLine("The Sudoku solution is invalid.");
        }
    }
}
