using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[,] reversedMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Reverse both row and column
                reversedMatrix[i, j] = matrix[rows - 1 - i, cols - 1 - j];
            }
        }

        // Output the reversed matrix
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