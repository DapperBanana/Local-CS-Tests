
using System;

class MatrixOperation
{
    static void Main()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int[,] resultAddition = new int[rows, cols];
        int[,] resultSubtraction = new int[rows, cols];

        // Matrix addition
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultAddition[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        // Matrix subtraction
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultSubtraction[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        // Print result matrices
        Console.WriteLine("Matrix Addition:");
        PrintMatrix(resultAddition, rows, cols);

        Console.WriteLine("Matrix Subtraction:");
        PrintMatrix(resultSubtraction, rows, cols);
    }

    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
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
