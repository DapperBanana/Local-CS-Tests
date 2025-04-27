
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {2, 4, 5},
            {3, 5, 6}
        };

        Console.WriteLine("Given Matrix:");
        PrintMatrix(matrix);

        bool isSymmetric = CheckSymmetry(matrix);
        
        if (isSymmetric)
        {
            Console.WriteLine("The matrix is symmetric.");
        }
        else
        {
            Console.WriteLine("The matrix is not symmetric.");
        }
    }

    static bool CheckSymmetry(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != matrix[j, i])
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
