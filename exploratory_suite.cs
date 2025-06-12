
using System;

class Program
{
    static void Main()
    {
        // Define the matrix dimensions
        int n = 3;

        // Define the matrix
        double[,] matrix = new double[,] {{2, -3, 1}, {3, 2, 5}, {1, 4, -2}};

        // Calculate and print the determinant of the matrix
        double determinant = CalculateDeterminant(matrix, n);
        Console.WriteLine($"The determinant of the matrix is: {determinant}");
    }

    static double CalculateDeterminant(double[,] matrix, int n)
    {
        double det = 0;

        if (n == 1)
        {
            det = matrix[0, 0];
        }
        else if (n == 2)
        {
            det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                det += matrix[0, i] * MatrixMinor(matrix, 0, i, n) * Math.Pow(-1, i);
            }
        }

        return det;
    }

    static double MatrixMinor(double[,] matrix, int row, int col, int size)
    {
        double[,] minor = new double[size - 1, size - 1];
        int minorRow = 0, minorCol = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i != row && j != col)
                {
                    minor[minorRow, minorCol] = matrix[i, j];
                    minorCol++;
                    if (minorCol == size - 1)
                    {
                        minorCol = 0;
                        minorRow++;
                    }
                }
            }
        }

        return CalculateDeterminant(minor, size - 1);
    }
}
