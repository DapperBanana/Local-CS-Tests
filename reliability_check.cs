
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

        // Reverse the rows and columns
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                reversedMatrix[j, i] = matrix[i, j];
            }
        }

        // Print the original matrix
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        // Print the reversed matrix
        Console.WriteLine("\nReversed Matrix:");
        PrintMatrix(reversedMatrix);
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
