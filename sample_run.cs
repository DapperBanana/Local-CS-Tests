
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
        };

        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        int[,] reversedMatrix = new int[numCols, numRows];

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
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
