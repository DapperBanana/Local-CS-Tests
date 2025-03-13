
using System;

class Program
{
    static void Main()
    {
        // Define the square matrix
        int[,] matrix = {
            { 2, 5, 3 },
            { 1, -2, -1 },
            { 1, 3, 4 }
        };

        // Calculate the determinant
        int determinant = CalculateDeterminant(matrix);

        // Print the determinant
        Console.WriteLine($"The determinant of the matrix is: {determinant}");
    }

    static int CalculateDeterminant(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int determinant = 0;

        if (n == 2)
        {
            determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                determinant += (int)Math.Pow(-1, i) * matrix[0, i] * CalculateDeterminant(GetSubMatrix(matrix, 0, i));
            }
        }

        return determinant;
    }

    static int[,] GetSubMatrix(int[,] matrix, int row, int col)
    {
        int n = matrix.GetLength(0);
        int[,] subMatrix = new int[n - 1, n - 1];

        for (int i = 0, k = 0; i < n; i++)
        {
            if (i == row) continue;

            for (int j = 0, l = 0; j < n; j++)
            {
                if (j == col) continue;

                subMatrix[k, l] = matrix[i, j];
                l++;
            }
            k++;
        }

        return subMatrix;
    }
}
