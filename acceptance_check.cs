
using System;

class MatrixOperations
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

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int[,] resultAddition = new int[rows, cols];
        int[,] resultSubtraction = new int[rows, cols];

        // Performing matrix addition
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultAddition[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        // Performing matrix subtraction
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultSubtraction[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        Console.WriteLine("Matrix Addition:");
        PrintMatrix(resultAddition);

        Console.WriteLine("\nMatrix Subtraction:");
        PrintMatrix(resultSubtraction);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
