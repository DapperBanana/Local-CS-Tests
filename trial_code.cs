
using System;

class MatrixOperations
{
    static bool IsInvertible(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            Console.WriteLine("Matrix is not square and cannot be inverted.");
            return false;
        }

        double determinant = CalculateDeterminant(matrix);

        if (determinant == 0)
        {
            Console.WriteLine("Matrix is singular and cannot be inverted.");
            return false;
        }

        return true;
    }

    static double CalculateDeterminant(int[,] matrix)
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
                determinant += Math.Pow(-1, i) * matrix[0, i] 
                    * CalculateDeterminant(GetMinor(matrix, 0, i));
            }
        }

        return determinant;
    }

    static int[,] GetMinor(int[,] matrix, int row, int col)
    {
        int[,] minor = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        int minorRow = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == row)
            {
                continue;
            }

            int minorCol = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == col)
                {
                    continue;
                }

                minor[minorRow, minorCol] = matrix[i, j];
                minorCol++;
            }

            minorRow++;
        }

        return minor;
    }

    static void Main()
    {
        int[,] testMatrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        if (IsInvertible(testMatrix))
        {
            Console.WriteLine("Matrix is invertible.");
        }
    }
}
