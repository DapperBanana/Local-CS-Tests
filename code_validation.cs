
using System;

class Program
{
    static void Main()
    {
        int[][] sudoku = new int[][]
        {
            new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
            new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
            new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
            new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
            new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
            new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
            new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
            new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
            new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
        };

        if (IsValidSudoku(sudoku))
        {
            Console.WriteLine("Valid sudoku solution!");
        }
        else
        {
            Console.WriteLine("Invalid sudoku solution!");
        }

        Console.ReadLine();
    }

    static bool IsValidSudoku(int[][] sudoku)
    {
        // Check rows
        for (int i = 0; i < 9; i++)
        {
            if (!IsValidSet(sudoku[i]))
            {
                return false;
            }
        }

        // Check columns
        for (int j = 0; j < 9; j++)
        {
            int[] column = new int[9];
            for (int i = 0; i < 9; i++)
            {
                column[i] = sudoku[i][j];
            }
            if (!IsValidSet(column))
            {
                return false;
            }
        }

        // Check 3x3 subgrids
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                int[] subgrid = new int[9];
                int index = 0;
                for (int ii = 0; ii < 3; ii++)
                {
                    for (int jj = 0; jj < 3; jj++)
                    {
                        subgrid[index++] = sudoku[i + ii][j + jj];
                    }
                }
                if (!IsValidSet(subgrid))
                {
                    return false;
                }
            }
        }

        return true;
    }

    static bool IsValidSet(int[] set)
    {
        Array.Sort(set);
        for (int i = 0; i < set.Length; i++)
        {
            if (set[i] != i + 1)
            {
                return false;
            }
        }
        return true;
    }
}
