
using System;

class MatrixInvertibilityChecker
{
    // Function to check if a matrix is invertible
    public static bool IsInvertible(int[,] matrix)
    {
        // Check if the matrix is square
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return false;
        }

        // Calculate the determinant of the matrix
        int determinant = CalculateDeterminant(matrix);

        // If determinant is non-zero, matrix is invertible
        return determinant != 0;
    }

    // Function to calculate the determinant of a matrix
    private static int CalculateDeterminant(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        if (n == 1)
        {
            return matrix[0, 0];
        }

        int determinant = 0;
        int sign = 1;

        for (int i = 0; i < n; i++)
        {
            int[,] subMatrix = GetSubMatrix(matrix, i);
            determinant += sign * matrix[0, i] * CalculateDeterminant(subMatrix);
            sign = -sign;
        }

        return determinant;
    }

    // Function to get the sub-matrix by removing the first row and i-th column
    private static int[,] GetSubMatrix(int[,] matrix, int columnIndex)
    {
        int n = matrix.GetLength(0);
        int[,] subMatrix = new int[n - 1, n - 1];

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j < columnIndex)
                {
                    subMatrix[i - 1, j] = matrix[i, j];
                }
                else if (j > columnIndex)
                {
                    subMatrix[i - 1, j - 1] = matrix[i, j];
                }
            }
        }

        return subMatrix;
    }

    static void Main()
    {
        int[,] matrix = {
            { 2, -3, 1 },
            { 4, 5, -3 },
            { 1, 2, -1 }
        };

        if (IsInvertible(matrix))
        {
            Console.WriteLine("Matrix is invertible.");
        }
        else
        {
            Console.WriteLine("Matrix is not invertible.");
        }
    }
}
