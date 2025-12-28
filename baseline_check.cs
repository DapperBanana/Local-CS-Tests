using System;

class Program
{
    static void Main()
    {
        // Example: Define a matrix to check
        double[,] matrix = {
            { 0, 1 },
            { -1, 0 }
        };

        bool isOrthogonal = IsOrthogonal(matrix);
        Console.WriteLine($"Is the matrix orthogonal? {isOrthogonal}");
    }

    static bool IsOrthogonal(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if matrix is square
        if (rows != cols)
            return false;

        double[,] transpose = Transpose(matrix);
        double[,] product = Multiply(matrix, transpose);

        // Check if product is identity
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j)
                {
                    if (Math.Abs(product[i, j] - 1) > 1e-6)
                        return false;
                }
                else
                {
                    if (Math.Abs(product[i, j]) > 1e-6)
                        return false;
                }
            }
        }

        return true;
    }

    static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transposed = new double[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transposed[j, i] = matrix[i, j];

        return transposed;
    }

    static double[,] Multiply(double[,] matrixA, double[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int colsB = matrixB.GetLength(1);

        if (colsA != rowsB)
            throw new InvalidOperationException("Incompatible matrix sizes for multiplication.");

        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
            for (int j = 0; j < colsB; j++)
                for (int k = 0; k < colsA; k++)
                    result[i, j] += matrixA[i, k] * matrixB[k, j];

        return result;
    }
}