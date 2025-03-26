
using System;

class SudokuValidator
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

        Console.WriteLine("Is the Sudoku solution valid? " + isValid);
    }

    static bool IsValidSudoku(int[,] sudoku)
    {
        for (int i = 0; i < 9; i++)
        {
            if (!IsValidRow(sudoku, i) || !IsValidColumn(sudoku, i) || !IsValidSubgrid(sudoku, i))
            {
                return false;
            }
        }

        return true;
    }

    static bool IsValidRow(int[,] sudoku, int row)
    {
        bool[] visited = new bool[9];

        for (int i = 0; i < 9; i++)
        {
            int num = sudoku[row, i];
            if (num < 1 || num > 9 || visited[num - 1])
            {
                return false;
            }
            visited[num - 1] = true;
        }

        return true;
    }

    static bool IsValidColumn(int[,] sudoku, int col)
    {
        bool[] visited = new bool[9];

        for (int i = 0; i < 9; i++)
        {
            int num = sudoku[i, col];
            if (num < 1 || num > 9 || visited[num - 1])
            {
                return false;
            }
            visited[num - 1] = true;
        }

        return true;
    }

    static bool IsValidSubgrid(int[,] sudoku, int subgrid)
    {
        int startRow = (subgrid / 3) * 3;
        int startCol = (subgrid % 3) * 3;

        bool[] visited = new bool[9];

        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                int num = sudoku[i, j];
                if (num < 1 || num > 9 || visited[num - 1])
                {
                    return false;
                }
                visited[num - 1] = true;
            }
        }

        return true;
    }
}
