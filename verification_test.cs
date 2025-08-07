
using System;

class MatrixMultiplication
{
    static void Main()
    {
        int[,] matrix1 = {
            {1, 2},
            {3, 4}
        };

        int[,] matrix2 = {
            {5, 6},
            {7, 8}
        };

        int[,] result = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("Result of matrix multiplication:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            throw new InvalidOperationException("Invalid matrix dimensions for multiplication");
        }

        int[,] result = new int[rows1, cols2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}
