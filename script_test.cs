
using System;

class MatrixOperations
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        int[,] reversedMatrix = ReverseMatrix(matrix);

        Console.WriteLine("\nReversed Matrix:");
        PrintMatrix(reversedMatrix);
    }

    static int[,] ReverseMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[,] reversedMatrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                reversedMatrix[i, j] = matrix[rows - 1 - i, columns - 1 - j];
            }
        }

        return reversedMatrix;
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
    }
}
