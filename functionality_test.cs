
using System;

class MatrixMultiplication
{
    static void Main()
    {
        int[,] matrix1 = {
            {1, 2},
            {3, 4}
        };
        
        int[,] matrix2 = {
            {5, 6},
            {7, 8}
        };

        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int columns2 = matrix2.GetLength(1);

        int[,] result = new int[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                for (int k = 0; k < columns1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("Resultant Matrix:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
