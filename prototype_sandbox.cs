
using System;

class MatrixSymmetryCheck
{
    static void Main()
    {
        int[,] matrix = { { 1, 2, 3 },
                          { 2, 4, 5 },
                          { 3, 5, 6 } };

        bool isSymmetric = CheckSymmetry(matrix);

        if (isSymmetric)
        {
            Console.WriteLine("The matrix is symmetric.");
        }
        else
        {
            Console.WriteLine("The matrix is not symmetric.");
        }
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
            for (int j = 0; j < i; j++)
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
