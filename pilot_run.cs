
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[,] reversedMatrix = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                reversedMatrix[j, i] = matrix[i, j];
            }
        }

        Console.WriteLine("Original matrix:");
        PrintMatrix(matrix);

        Console.WriteLine("\nReversed matrix:");
        PrintMatrix(reversedMatrix);
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
}
