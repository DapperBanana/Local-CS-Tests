
using System;

class Program
{
    static void Main()
    {
        int n = 3; // Size of the square matrix
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Matrix:");
        PrintMatrix(matrix, n);

        int det = CalculateDeterminant(matrix, n);
        Console.WriteLine("Determinant: " + det);
    }

    static int CalculateDeterminant(int[,] matrix, int n)
    {
        if (n == 1) // Base case
        {
            return matrix[0, 0];
        }

        int determinant = 0;
        int sign = 1;

        for (int i = 0; i < n; i++)
        {
            int[,] subMatrix = new int[n - 1, n - 1];

            for (int row = 1; row < n; row++)
            {
                int colIndex = 0;
                for (int col = 0; col < n; col++)
                {
                    if (col != i)
                    {
                        subMatrix[row - 1, colIndex] = matrix[row, col];
                        colIndex++;
                    }
                }
            }

            determinant += sign * matrix[0, i] * CalculateDeterminant(subMatrix, n - 1);
            sign *= -1;
        }

        return determinant;
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
