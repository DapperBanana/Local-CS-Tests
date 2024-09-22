
using System;

public class MatrixInvertibilityChecker
{
    public static bool IsMatrixInvertible(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return false;
        }

        int size = matrix.GetLength(0);

        double determinant = CalculateDeterminant(matrix, size);

        return determinant != 0;
    }

    private static double CalculateDeterminant(double[,] matrix, int size)
    {
        if (size == 1)
        {
            return matrix[0, 0];
        }

        double determinant = 0;
        int sign = 1;

        for (int i = 0; i < size; i++)
        {
            double[,] subMatrix = CreateSubMatrix(matrix, size, i);
            determinant += sign * matrix[0, i] * CalculateDeterminant(subMatrix, size - 1);
            sign = -sign;
        }

        return determinant;
    }

    private static double[,] CreateSubMatrix(double[,] matrix, int size, int excludeCol)
    {
        double[,] subMatrix = new double[size - 1, size - 1];

        int k = 0, l = 0;
        for (int i = 1; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (j != excludeCol)
                {
                    subMatrix[k, l] = matrix[i, j];
                    l++;
                }
            }
            k++;
            l = 0;
        }

        return subMatrix;
    }

    public static void Main()
    {
        double[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        if (IsMatrixInvertible(matrix))
        {
            Console.WriteLine("The matrix is invertible.");
        }
        else
        {
            Console.WriteLine("The matrix is not invertible.");
        }
    }
}
