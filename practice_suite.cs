
using System;

class MatrixOrthogonalChecker
{
    static bool IsMatrixOrthogonal(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false; // Cannot be orthogonal if not a square matrix
        }

        // Transpose the matrix
        double[,] transpose = new double[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        // Multiply the matrix by its transpose
        double[,] result = new double[rows, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < cols; k++)
                {
                    result[i, j] += matrix[i, k] * transpose[k, j];
                }
            }
        }

        // Check if the result matrix is the identity matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                if (i == j && Math.Abs(result[i, j] - 1) > 0.0001)
                {
                    return false;
                }
                else if (i != j && Math.Abs(result[i, j]) > 0.0001)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Main()
    {
        double[,] matrix = {
            {1, 0, 0},
            {0, 1, 0},
            {0, 0, 1}
        };

        if (IsMatrixOrthogonal(matrix))
        {
            Console.WriteLine("The matrix is orthogonal");
        }
        else
        {
            Console.WriteLine("The matrix is not orthogonal");
        }
    }
}
