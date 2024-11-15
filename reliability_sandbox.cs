
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

        bool isValid = ValidateSudoku(sudoku);

        Console.WriteLine("Is the Sudoku solution valid? " + isValid);
    }

    static bool ValidateSudoku(int[,] sudoku)
    {
        for (int i = 0; i < 9; i++)
        {
            var rowSet = new HashSet<int>();
            var colSet = new HashSet<int>();
            var cubeSet = new HashSet<int>();
            
            for (int j = 0; j < 9; j++)
            {
                if (!rowSet.Add(sudoku[i, j]) || !colSet.Add(sudoku[j, i]) || !cubeSet.Add(sudoku[3 * (i / 3) + j / 3, 3 * (i % 3) + j % 3]))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
