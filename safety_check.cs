
using System;

class MatrixDeterminantCalculator
{
    static double Determinant(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        double det = 0;

        if (n == 1)
        {
            return matrix[0, 0];
        }
        else if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                double[,] minor = CreateMinor(matrix, i);
                det += Math.Pow(-1, i) * matrix[0, i] * Determinant(minor);
            }
        }

        return det;
    }

    static double[,] CreateMinor(double[,] matrix, int col)
    {
        int n = matrix.GetLength(0);
        double[,] minor = new double[n - 1, n - 1];

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j < col)
                    minor[i - 1, j] = matrix[i, j];
                else if (j > col)
                    minor[i - 1, j - 1] = matrix[i, j];
            }
        }

        return minor;
    }

    static void Main()
    {
        double[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double det = Determinant(matrix);

        Console.WriteLine("Determinant of the matrix:");
        Console.WriteLine(det);
    }
}
