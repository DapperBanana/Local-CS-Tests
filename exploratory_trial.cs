
using System;

class MatrixInvertibility
{
    static bool IsInvertible(double[,] matrix)
    {
        int n = matrix.GetLength(0);

        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return false; // Only square matrices can be invertible
        }

        double determinant = CalculateDeterminant(matrix);

        return determinant != 0;
    }

    static double CalculateDeterminant(double[,] matrix)
    {
        int n = matrix.GetLength(0);

        if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else
        {
            double det = 0;

            for (int i = 0; i < n; i++)
            {
                double[,] minor = GetMinor(matrix, i, 0);
                det += Math.Pow(-1, i) * matrix[i, 0] * CalculateDeterminant(minor);
            }

            return det;
        }
    }

    static double[,] GetMinor(double[,] matrix, int row, int col)
    {
        int n = matrix.GetLength(0);
        double[,] minor = new double[n - 1, n - 1];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != row && j != col)
                {
                    if (i > row && j > col)
                    {
                        minor[i - 1, j - 1] = matrix[i, j];
                    }
                    else if (i > row)
                    {
                        minor[i - 1, j] = matrix[i, j];
                    }
                    else if (j > col)
                    {
                        minor[i, j - 1] = matrix[i, j];
                    }
                    else
                    {
                        minor[i, j] = matrix[i, j];
                    }
                }
            }
        }

        return minor;
    }

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
}
