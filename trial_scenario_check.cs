
using System;

class Program
{
    static bool IsValidSudoku(int[,] board)
    {
        // Check rows
        for (int i = 0; i < 9; i++)
        {
            bool[] seen = new bool[10];
            for (int j = 0; j < 9; j++)
            {
                if (board[i, j] != 0 && seen[board[i, j]])
                    return false;
                seen[board[i, j]] = true;
            }
        }

        // Check columns
        for (int j = 0; j < 9; j++)
        {
            bool[] seen = new bool[10];
            for (int i = 0; i < 9; i++)
            {
                if (board[i, j] != 0 && seen[board[i, j]])
                    return false;
                seen[board[i, j]] = true;
            }
        }

        // Check 3x3 subgrids
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                bool[] seen = new bool[10];
                for (int k = i * 3; k < i * 3 + 3; k++)
                {
                    for (int l = j * 3; l < j * 3 + 3; l++)
                    {
                        if (board[k, l] != 0 && seen[board[k, l]])
                            return false;
                        seen[board[k, l]] = true;
                    }
                }
            }
        }

        return true;
    }

    static void Main()
    {
        int[,] sudokuBoard = {
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

        if (IsValidSudoku(sudokuBoard))
        {
            Console.WriteLine("Valid Sudoku solution.");
        }
        else
        {
            Console.WriteLine("Invalid Sudoku solution.");
        }
    }
}
