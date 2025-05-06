
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

        int[,] reversedMatrix = new int[rows, cols];

        // Reverse rows
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                reversedMatrix[rows - i - 1, j] = matrix[i, j];
            }
        }

        // Reverse columns
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, cols - j - 1] = reversedMatrix[i, j];
            }
        }

        // Print the reversed matrix
        Console.WriteLine("Reversed Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(reversedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
