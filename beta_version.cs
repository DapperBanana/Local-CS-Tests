
using System;

class MatrixSymmetry
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {2, 4, 5},
            {3, 5, 6}
        };
        
        bool isSymmetric = CheckSymmetry(matrix);
        
        Console.WriteLine("Is matrix symmetric: " + isSymmetric);
    }

    static bool CheckSymmetry(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] != matrix[j, i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
