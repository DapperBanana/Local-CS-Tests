
using System;

class Program
{
    static bool ValidateSudoku(int[,] board)
    {
        // Check rows and columns
        for (int i = 0; i < 9; i++)
        {
            bool[] rowCheck = new bool[9];
            bool[] colCheck = new bool[9];

            for (int j = 0; j < 9; j++)
            {
                if (rowCheck[board[i, j] - 1] || colCheck[board[j, i] - 1])
                {
                    return false;
                }

                rowCheck[board[i, j] - 1] = true;
                colCheck[board[j, i] - 1] = true;
            }
        }

        // Check 3x3 subgrids
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                bool[] subgridCheck = new bool[9];

                for (int k = i; k < i + 3; k++)
                {
                    for (int l = j; l < j + 3; l++)
                    {
                        if (subgridCheck[board[k, l] - 1])
                        {
                            return false;
                        }

                        subgridCheck[board[k, l] - 1] = true;
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
            {3, 4, 5, 2, 8, 6, -1, 7, 9} // Invalid entry
        };

        if (ValidateSudoku(board))
        {
            Console.WriteLine("This is a valid Sudoku solution.");
        }
        else
        {
            Console.WriteLine("This is not a valid Sudoku solution.");
        }
    }
}
