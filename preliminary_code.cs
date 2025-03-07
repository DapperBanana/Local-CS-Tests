
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
        int columns = matrix.GetLength(1);

        // Reverse the order of rows
        Array.Reverse(matrix, 0, rows);

        // Create a new matrix to hold the result
        int[,] reversedMatrix = new int[columns, rows];
        
        // Reverse the order of columns
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                reversedMatrix[j, i] = matrix[i, j];
            }
        }

        // Print the reversed matrix
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(reversedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
