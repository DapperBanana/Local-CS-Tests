
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

        // Reverse the order of rows
        for (int i = 0; i < rows / 2; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[rows - 1 - i, j];
                matrix[rows - 1 - i, j] = temp;
            }
        }

        // Reverse the order of columns
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, cols - 1 - j];
                matrix[i, cols - 1 - j] = temp;
            }
        }

        // Print the reversed matrix
        Console.WriteLine("Reversed Matrix:");
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
