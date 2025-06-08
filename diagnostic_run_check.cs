
using System;

class MatrixOperations
{
    static void Main()
    {
        int rows = 2;
        int columns = 2;

        int[,] matrix1 = new int[rows, columns] { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = new int[rows, columns] { { 5, 6 }, { 7, 8 } };

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2);

        int[,] resultAddition = AddMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix Addition:");
        PrintMatrix(resultAddition);

        int[,] resultSubtraction = SubtractMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix Subtraction:");
        PrintMatrix(resultSubtraction);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }
}
