
using System;

class Program
{
    static void Main()
    {
        int n = 3;

        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int determinant = CalculateDeterminant(matrix, n);

        Console.WriteLine("The determinant of the matrix is: " + determinant);
    }

    static int CalculateDeterminant(int[,] matrix, int n)
    {
        if (n == 1)
        {
            return matrix[0, 0];
        }

        int det = 0;
        int sign = 1;

        for (int i = 0; i < n; i++)
        {
            int[,] subMatrix = CreateSubMatrix(matrix, n, i);
            det += sign * matrix[0, i] * CalculateDeterminant(subMatrix, n - 1);
            sign *= -1;
        }

        return det;
    }

    static int[,] CreateSubMatrix(int[,] matrix, int n, int col)
    {
        int[,] subMatrix = new int[n - 1, n - 1];

        for (int i = 1; i < n; i++)
        {
            int k = 0;

            for (int j = 0; j < n; j++)
            {
                if (j == col)
                    continue;

                subMatrix[i - 1, k] = matrix[i, j];
                k++;
            }
        }

        return subMatrix;
    }
}
