
using System;

class Program
{
    static bool ValidateSudoku(int[,] board)
    {
        // Check rows
        for (int i = 0; i < 9; i++)
        {
            bool[] rowNumbers = new bool[9];
            for (int j = 0; j < 9; j++)
            {
                if (board[i, j] != 0)
                {
                    if (rowNumbers[board[i, j] - 1])
                        return false;
                    rowNumbers[board[i, j] - 1] = true;
                }
            }
        }
        
        // Check columns
        for (int j = 0; j < 9; j++)
        {
            bool[] colNumbers = new bool[9];
            for (int i = 0; i < 9; i++)
            {
                if (board[i, j] != 0)
                {
                    if (colNumbers[board[i, j] - 1])
                        return false;
                    colNumbers[board[i, j] - 1] = true;
                }
            }
        }
        
        // Check 3x3 grids
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                bool[] gridNumbers = new bool[9];
                for (int k = i; k < i + 3; k++)
                {
                    for (int l = j; l < j + 3; l++)
                    {
                        if (board[k, l] != 0)
                        {
                            if (gridNumbers[board[k, l] - 1])
                                return false;
                            gridNumbers[board[k, l] - 1] = true;
                        }
                    }
                }
            }
        }
        
        return true;
    }

    static void Main()
    {
        int[,] board = new int[,]
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

        if (ValidateSudoku(board))
            Console.WriteLine("Valid Sudoku solution");
        else
            Console.WriteLine("Invalid Sudoku solution");
    }
}
