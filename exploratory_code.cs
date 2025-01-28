
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

        if (IsValidSudoku(sudoku))
        {
            Console.WriteLine("Sudoku solution is valid.");
        }
        else
        {
            Console.WriteLine("Sudoku solution is not valid.");
        }
    }

    static bool IsValidSudoku(int[,] sudoku)
    {
        // Check rows
        for (int i = 0; i < 9; i++)
        {
            if (!IsValidSet(GetRow(sudoku, i)))
            {
                return false;
            }
        }

        // Check columns
        for (int i = 0; i < 9; i++)
        {
            if (!IsValidSet(GetColumn(sudoku, i)))
            {
                return false;
            }
        }

        // Check subgrids
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                if (!IsValidSet(GetSubgrid(sudoku, i, j)))
                {
                    return false;
                }
            }
        }

        return true;
    }

    static int[] GetRow(int[,] sudoku, int row)
    {
        int[] result = new int[9];

        for (int i = 0; i < 9; i++)
        {
            result[i] = sudoku[row, i];
        }

        return result;
    }

    static int[] GetColumn(int[,] sudoku, int col)
    {
        int[] result = new int[9];

        for (int i = 0; i < 9; i++)
        {
            result[i] = sudoku[i, col];
        }

        return result;
    }

    static int[] GetSubgrid(int[,] sudoku, int startRow, int startCol)
    {
        int[] result = new int[9];
        int index = 0;

        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                result[index] = sudoku[i, j];
                index++;
            }
        }

        return result;
    }

    static bool IsValidSet(int[] set)
    {
        Array.Sort(set);

        for (int i = 0; i < 9; i++)
        {
            if (set[i] != i + 1)
            {
                return false;
            }
        }

        return true;
    }
}
