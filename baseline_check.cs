
using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrix2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int[,] resultAddition = new int[rows, cols];
        int[,] resultSubtraction = new int[rows, cols];

        Console.WriteLine("Matrix Addition:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultAddition[i, j] = matrix1[i, j] + matrix2[i, j];
                Console.Write(resultAddition[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nMatrix Subtraction:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultSubtraction[i, j] = matrix1[i, j] - matrix2[i, j];
                Console.Write(resultSubtraction[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
