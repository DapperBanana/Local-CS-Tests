
using System;

class MatrixReverse
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

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                reversedMatrix[rows - 1 - i, cols - 1 - j] = matrix[i, j];
            }
        }

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        Console.WriteLine("Reversed Matrix:");
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
        Console.WriteLine();
    }
}
