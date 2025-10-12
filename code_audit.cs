
using System;

class MatrixInvertibilityChecker
{
    static void Main()
    {
        double[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        if (IsInvertible(matrix))
        {
            Console.WriteLine("The matrix is invertible.");
        }
        else
        {
            Console.WriteLine("The matrix is not invertible.");
        }
    }

    static bool IsInvertible(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return false;
        }

        double determinant = GetDeterminant(matrix);
        return determinant != 0;
    }

    static double GetDeterminant(double[,] matrix)
    {
        double determinant = 0;

        if (matrix.GetLength(0) == 2)
        {
            determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
        else
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                determinant += matrix[0, i] * GetMinor(matrix, 0, i) * Math.Pow(-1, i);
            }
        }

        return determinant;
    }

    static double GetMinor(double[,] matrix, int rowToRemove, int colToRemove)
    {
        double[,] minorMatrix = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        int minorRow = 0;
        int minorCol = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == rowToRemove)
            {
                continue;
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == colToRemove)
                {
                    continue;
                }

                minorMatrix[minorRow, minorCol] = matrix[i, j];
                minorCol++;
            }

            minorCol = 0;
            minorRow++;
        }

        return GetDeterminant(minorMatrix);
    }
}
