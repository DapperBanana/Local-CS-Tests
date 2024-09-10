
using System;

class Program
{
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

        bool isValid = IsValidSudoku(sudoku);
        
        if(isValid)
        {
            Console.WriteLine("The Sudoku solution is valid.");
        }
        else
        {
            Console.WriteLine("The Sudoku solution is not valid.");
        }
    }

    static bool IsValidSudoku(int[,] sudoku)
    {
        for(int i = 0; i < 9; i++)
        {
            if(!IsValidRow(i, sudoku) || !IsValidColumn(i, sudoku) || !IsValidSquare(i, sudoku))
            {
                return false;
            }
        }
        
        return true;
    }

    static bool IsValidRow(int row, int[,] sudoku)
    {
        bool[] found = new bool[9];

        for(int i = 0; i < 9; i++)
        {
            if(found[sudoku[row, i] - 1])
            {
                return false;
            }

            found[sudoku[row, i] - 1] = true;
        }

        return true;
    }

    static bool IsValidColumn(int col, int[,] sudoku)
    {
        bool[] found = new bool[9];

        for(int i = 0; i < 9; i++)
        {
            if(found[sudoku[i, col] - 1])
            {
                return false;
            }

            found[sudoku[i, col] - 1] = true;
        }

        return true;
    }

    static bool IsValidSquare(int square, int[,] sudoku)
    {
        int startRow = (square / 3) * 3;
        int startCol = (square % 3) * 3;
        bool[] found = new bool[9];

        for(int i = startRow; i < startRow + 3; i++)
        {
            for(int j = startCol; j < startCol + 3; j++)
            {
                if(found[sudoku[i, j] - 1])
                {
                    return false;
                }

                found[sudoku[i, j] - 1] = true;
            }
        }

        return true;
    }
}
