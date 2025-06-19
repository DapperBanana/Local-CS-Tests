
using System;

public class MatrixInvertibility
{
    public static bool IsInvertible(int[,] matrix)
    {
        int determinant = GetDeterminant(matrix);

        return determinant != 0;
    }

    public static int GetDeterminant(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            throw new Exception("Matrix is not square.");
        }

        int n = matrix.GetLength(0);
        if (n == 1)
        {
            return matrix[0, 0];
        }

        int det = 0;

        for (int i = 0; i < n; i++)
        {
            int sign = (i % 2 == 0) ? 1 : -1;
            int[,] minor = GetMinor(matrix, 0, i);
            det += sign * matrix[0, i] * GetDeterminant(minor);
        }

        return det;
    }

    public static int[,] GetMinor(int[,] matrix, int row, int col)
    {
        int n = matrix.GetLength(0);
        int[,] minor = new int[n - 1, n - 1];

        for (int i = 0, k = 0; i < n; i++)
        {
            if (i == row)
            {
                continue;
            }

            for (int j = 0, l = 0; j < n; j++)
            {
                if (j == col)
                {
                    continue;
                }

                minor[k, l] = matrix[i, j];
                l++;
            }

            k++;
        }

        return minor;
    }

    public static void Main()
    {
        int[,] matrix = new int[,] {{1, 2, 3},
                                    {4, 5, 6},
                                    {7, 8, 9}};

        if (IsInvertible(matrix))
        {
            Console.WriteLine("Matrix is invertible.");
        }
        else
        {
            Console.WriteLine("Matrix is not invertible.");
        }
    }
}
