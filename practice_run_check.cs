
using System;

class MatrixDeterminantCalculator
{
    static int GetDeterminant(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            throw new ArgumentException("Matrix should be square.");
        }

        int n = matrix.GetLength(0);
        int det = 0;

        if (n == 2)
        {
            det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                int[,] minor = GetMinor(matrix, i, 0);
                det += (int)Math.Pow(-1, i) * matrix[i, 0] * GetDeterminant(minor);
            }
        }

        return det;
    }

    static int[,] GetMinor(int[,] matrix, int rowToDelete, int colToDelete)
    {
        int n = matrix.GetLength(0);
        int[,] minor = new int[n - 1, n - 1];

        for (int i = 0, k = 0; i < n; i++)
        {
            if (i == rowToDelete)
            {
                continue;
            }

            for (int j = 0, l = 0; j < n; j++)
            {
                if (j != colToDelete)
                {
                    minor[k, l] = matrix[i, j];
                    l++;
                }
            }

            k++;
        }

        return minor;
    }

    static void Main(string[] args)
    {
        int[,] matrix = {
            { 2, 3, 1 },
            { 0, -1, 4 },
            { 5, 2, 7 }
        };

        int determinant = GetDeterminant(matrix);

        Console.WriteLine($"Determinant of the matrix is: {determinant}");
    }
}
