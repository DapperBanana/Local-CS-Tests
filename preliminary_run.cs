
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int determinant = CalculateDeterminant(matrix);

        Console.WriteLine($"The determinant of the matrix is: {determinant}");
    }

    static int CalculateDeterminant(int[,] matrix)
    {
        int determinant = 0;
        int n = matrix.GetLength(0);

        if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        for (int i = 0; i < n; i++)
        {
            int[,] subMatrix = CreateSubMatrix(matrix, i);
            int sign = i % 2 == 0 ? 1 : -1;
            determinant += sign * matrix[0, i] * CalculateDeterminant(subMatrix);
        }

        return determinant;
    }

    static int[,] CreateSubMatrix(int[,] matrix, int col)
    {
        int n = matrix.GetLength(0);
        int[,] subMatrix = new int[n - 1, n - 1];
        int p = 0;
        int q = 0;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == col)
                    continue;
                subMatrix[p, q] = matrix[i, j];
                q++;
                if (q == n - 1)
                {
                    q = 0;
                    p++;
                }
            }
        }

        return subMatrix;
    }
}
