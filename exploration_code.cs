
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

        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        int[,] reversedMatrix = new int[colCount, rowCount];

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                reversedMatrix[j, i] = matrix[i, j];
            }
        }

        for (int i = 0; i < colCount; i++)
        {
            for (int j = 0; j < rowCount; j++)
            {
                Console.Write(reversedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
