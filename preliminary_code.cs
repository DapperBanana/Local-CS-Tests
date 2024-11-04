
using System;

class Program
{
    static void Main()
    {
        double[,] matrix = {
            {1, 0, 0},
            {0, 1, 0},
            {0, 0, 1}
        };

        if (IsOrthogonal(matrix))
        {
            Console.WriteLine("The matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("The matrix is not orthogonal.");
        }
    }

    static bool IsOrthogonal(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false;
        }

        // Check if the transpose of the matrix is equal to its inverse
        double[,] transpose = Transpose(matrix);
        double[,] product = Multiply(matrix, transpose);

        return IsIdentityMatrix(product);
    }

    static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] transpose = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        return transpose;
    }

    static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);

        double[,] product = new double[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                double sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                product[i, j] = sum;
            }
        }

        return product;
    }

    static bool IsIdentityMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j && Math.Abs(matrix[i, j] - 1) > 0.0001)
                {
                    return false;
                }
                else if (i != j && Math.Abs(matrix[i, j]) > 0.0001)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
