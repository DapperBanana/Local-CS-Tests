
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
        Console.WriteLine("Determinant of the matrix is: " + determinant);
    }

    static int CalculateDeterminant(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            throw new ArgumentException("Matrix must be square");
        }

        int n = matrix.GetLength(0);
        if (n == 2)
        {
            return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
        
        int determinant = 0;
        for (int i = 0; i < n; i++)
        {
            determinant += matrix[0, i] * Cofactor(matrix, 0, i);
        }

        return determinant;
    }

    static int Cofactor(int[,] matrix, int row, int col)
    {
        int n = matrix.GetLength(0);
        int[,] minor = new int[n - 1, n - 1];
        int minorRow = 0, minorCol = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != row && j != col)
                {
                    minor[minorRow, minorCol] = matrix[i, j];
                    minorCol++;
                    if (minorCol == n - 1)
                    {
                        minorCol = 0;
                        minorRow++;
                    }
                }
            }
        }

        int cofactor = (int)Math.Pow(-1, row + col) * CalculateDeterminant(minor);
        return cofactor;
    }
}
