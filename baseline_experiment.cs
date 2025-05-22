
using System;

class Program
{
    static void Main()
    {
        int[,] sudokuSolution = {
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

        if (IsValidSudoku(sudokuSolution))
        {
            Console.WriteLine("The Sudoku solution is valid.");
        }
        else
        {
            Console.WriteLine("The Sudoku solution is not valid.");
        }
    }

    static bool IsValidSudoku(int[,] board)
    {
        // Check rows
        for (int i = 0; i < 9; i++)
        {
            if (!IsValidRow(board, i))
            {
                return false;
            }
        }

        // Check columns
        for (int j = 0; j < 9; j++)
        {
            if (!IsValidColumn(board, j))
            {
                return false;
            }
        }

        // Check subgrids
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!IsValidSubgrid(board, i * 3, j * 3))
                {
                    return false;
                }
            }
        }

        return true;
    }

    static bool IsValidRow(int[,] board, int row)
    {
        bool[] seen = new bool[10];

        for (int j = 0; j < 9; j++)
        {
            int num = board[row, j];

            if (num != 0 && seen[num])
            {
                return false;
            }

            seen[num] = true;
        }

        return true;
    }

    static bool IsValidColumn(int[,] board, int column)
    {
        bool[] seen = new bool[10];

        for (int i = 0; i < 9; i++)
        {
            int num = board[i, column];

            if (num != 0 && seen[num])
            {
                return false;
            }

            seen[num] = true;
        }

        return true;
    }

    static bool IsValidSubgrid(int[,] board, int startRow, int startColumn)
    {
        bool[] seen = new bool[10];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int num = board[startRow + i, startColumn + j];

                if (num != 0 && seen[num])
                {
                    return false;
                }

                seen[num] = true;
            }
        }

        return true;
    }
}
