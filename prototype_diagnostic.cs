using System;

class Program
{
    static void Main()
    {
        // Example matrix:
        int[,] matrix = {
            { 4, 3 },
            { 6, 3 }
        };

        int size = matrix.GetLength(0);
        if(size != matrix.GetLength(1))
        {
            Console.WriteLine("The matrix must be square.");
            return;
        }

        double determinant = CalculateDeterminant(matrix);
        Console.WriteLine($"Determinant: {determinant}");
    }

    static double CalculateDeterminant(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        if (n == 1)
        {
            return matrix[0, 0];
        }
        if (n == 2)
        {
            return matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0];
        }

        double det = 0;
        for (int p = 0; p < n; p++)
        {
            int[,] subMatrix = CreateSubMatrix(matrix, 0, p);
            det += matrix[0, p] * Math.Pow(-1, p) * CalculateDeterminant(subMatrix);
        }

        return det;
    }

    static int[,] CreateSubMatrix(int[,] matrix, int excludingRow, int excludingCol)
    {
        int n = matrix.GetLength(0);
        int[,] result = new int[n - 1, n - 1];
        int r = 0, c;

        for (int i = 0; i < n; i++)
        {
            if (i == excludingRow)
                continue;

            c = 0;
            for (int j = 0; j < n; j++)
            {
                if (j == excludingCol)
                    continue;

                result[r, c] = matrix[i, j];
                c++;
            }
            r++;
        }
        return result;
    }
}