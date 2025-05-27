
using System;

class MatrixDeterminant
{
    static int Determinant(int[,] matrix)
    {
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
                det += (int)Math.Pow(-1, i) * matrix[0, i] * Determinant(GetSubMatrix(matrix, i));
            }
        }

        return det;
    }

    static int[,] GetSubMatrix(int[,] matrix, int col)
    {
        int n = matrix.GetLength(0);
        int[,] subMatrix = new int[n - 1, n - 1];
        int rowPtr = 0, colPtr = 0;

        for (int i = 1; i < n; i++)
        {
            colPtr = 0;

            for (int j = 0; j < n; j++)
            {
                if (j == col)
                {
                    continue;
                }

                subMatrix[rowPtr, colPtr] = matrix[i, j];
                colPtr++;
            }

            rowPtr++;
        }

        return subMatrix;
    }

    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int determinant = Determinant(matrix);
        Console.WriteLine($"The determinant of the matrix is: {determinant}");
    }
}
