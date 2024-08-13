
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = { { 1, 2 }, { 3, 4 } }; // example matrix
        bool isInvertible = IsInvertible(matrix);

        if (isInvertible)
        {
            Console.WriteLine("The matrix is invertible.");
        }
        else
        {
            Console.WriteLine("The matrix is not invertible.");
        }
    }

    static bool IsInvertible(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return false; // check if the matrix is square
        }

        double det = CalculateDeterminant(matrix);

        if(det != 0)
        {
            return true; // matrix is invertible if its determinant is non-zero
        }
        else
        {
            return false; // matrix is not invertible if its determinant is zero
        }
    }

    static double CalculateDeterminant(int[,] matrix)
    {
        if (matrix.GetLength(0) == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]; // determinant formula for 2x2 matrix
        }

        double det = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            det += matrix[0, i] * Math.Pow(-1, i) * CalculateDeterminant(GetSubMatrix(matrix, 0, i));
        }

        return det;
    }

    static int[,] GetSubMatrix(int[,] matrix, int row, int col)
    {
        int n = matrix.GetLength(0);
        int[,] subMatrix = new int[n - 1, n - 1];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i < row && j < col)
                    subMatrix[i, j] = matrix[i, j];
                else if (i < row && j > col)
                    subMatrix[i, j - 1] = matrix[i, j];
                else if (i > row && j < col)
                    subMatrix[i - 1, j] = matrix[i, j];
                else if (i > row && j > col)
                    subMatrix[i - 1, j - 1] = matrix[i, j];
            }
        }

        return subMatrix;
    }
}
