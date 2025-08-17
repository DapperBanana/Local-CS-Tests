
using System;

class SudokuValidator
{
    static bool IsValidSudoku(int[,] board)
    {
        HashSet<string> set = new HashSet<string>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i, j] != 0)
                {
                    string rowValue = $"row{board[i, j]} in row {i}";
                    string colValue = $"col{board[i, j]} in col {j}";
                    string boxValue = $"box{board[i, j]} in box {(i/3)*3 + j/3}";

                    if (!set.Add(rowValue) || !set.Add(colValue) || !set.Add(boxValue))
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        int[,] sudoku = new int[,] {
            {5, 3, 0, 0, 7, 0, 0, 0, 0},
            {6, 0, 0, 1, 9, 5, 0, 0, 0},
            {0, 9, 8, 0, 0, 0, 0, 6, 0},
            {8, 0, 0, 0, 6, 0, 0, 0, 3},
            {4, 0, 0, 8, 0, 3, 0, 0, 1},
            {7, 0, 0, 0, 2, 0, 0, 0, 6},
            {0, 6, 0, 0, 0, 0, 2, 8, 0},
            {0, 0, 0, 4, 1, 9, 0, 0, 5},
            {0, 0, 0, 0, 8, 0, 0, 7, 9}
        };

        if (IsValidSudoku(sudoku))
        {
            Console.WriteLine("Valid Sudoku solution");
        }
        else
        {
            Console.WriteLine("Invalid Sudoku solution");
        }
    }
}
