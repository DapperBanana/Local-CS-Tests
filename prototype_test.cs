
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Original matrix:");
        PrintMatrix(matrix);

        ReverseMatrix(matrix);

        Console.WriteLine("Reversed matrix:");
        PrintMatrix(matrix);
    }

    static void ReverseMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        
        int[,] tempMatrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                tempMatrix[i, j] = matrix[rows - 1 - i, columns - 1 - j];
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = tempMatrix[i, j];
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
