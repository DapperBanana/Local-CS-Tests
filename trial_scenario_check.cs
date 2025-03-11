
using System;

class MatrixOperation
{
    static void Main()
    {
        int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] matrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2);

        int[,] sumMatrix = AddMatrix(matrix1, matrix2);
        Console.WriteLine("Matrix 1 + Matrix 2:");
        PrintMatrix(sumMatrix);

        int[,] differenceMatrix = SubtractMatrix(matrix1, matrix2);
        Console.WriteLine("Matrix 1 - Matrix 2:");
        PrintMatrix(differenceMatrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] AddMatrix(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    static int[,] SubtractMatrix(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }
}
