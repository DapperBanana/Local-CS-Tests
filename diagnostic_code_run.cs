
using System;

class MatrixOperations
{
    static void Main()
    {
        int rows = 3;
        int columns = 3;

        int[,] matrix1 = new int[rows, columns] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        int[,] matrix2 = new int[rows, columns] { {9, 8, 7}, {6, 5, 4}, {3, 2, 1} };

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nMatrix 2:");
        PrintMatrix(matrix2);

        int[,] resultMatrix = AddMatrices(matrix1, matrix2);

        Console.WriteLine("\nResult Matrix (Addition):");
        PrintMatrix(resultMatrix);

        resultMatrix = SubtractMatrices(matrix1, matrix2);

        Console.WriteLine("\nResult Matrix (Subtraction):");
        PrintMatrix(resultMatrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] resultMatrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return resultMatrix;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] resultMatrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return resultMatrix;
    }
}
