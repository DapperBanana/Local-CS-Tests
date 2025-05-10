
using System;

class Program
{
    static bool IsInvertible(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return false;
        
        double determinant = CalculateDeterminant(matrix);
        
        return determinant != 0;
    }

    static double CalculateDeterminant(double[,] matrix)
    {
        if (matrix.GetLength(0) == 1)
            return matrix[0, 0];
        
        double determinant = 0;

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            determinant += matrix[0, i] * Cofactor(matrix, 0, i);
        }

        return determinant;
    }

    static double Cofactor(double[,] matrix, int row, int col)
    {
        return Minor(matrix, row, col) * Math.Pow(-1, row + col);
    }

    static double Minor(double[,] matrix, int row, int col)
    {
        double[,] minor = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

        int minorRow = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == row)
                continue;

            int minorCol = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == col)
                    continue;

                minor[minorRow, minorCol] = matrix[i, j];
                minorCol++;
            }

            minorRow++;
        }

        return CalculateDeterminant(minor);
    }

    static void Main()
    {
        double[,] matrix = {
            {2, -1, 0},
            {0, 1, 2},
            {1, 1, 1}
        };

        if (IsInvertible(matrix))
        {
            Console.WriteLine("The matrix is invertible.");
        }
        else
        {
            Console.WriteLine("The matrix is not invertible.");
        }
    }
}
