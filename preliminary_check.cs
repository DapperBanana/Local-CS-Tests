
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6}
        };

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int[,] reversedMatrix = new int[columns, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                reversedMatrix[j, i] = matrix[i, j];
            }
        }

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        Console.WriteLine("Reversed Matrix:");
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
