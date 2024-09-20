
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = { { 2, 5, 3 }, { 1, -2, -1 }, { 1, 3, 4 } };
        int n = 3; // Size of the square matrix
        
        Console.WriteLine("Matrix:");
        PrintMatrix(matrix, n);

        int determinant = CalculateDeterminant(matrix, n);
        
        Console.WriteLine("\nDeterminant: " + determinant);
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculateDeterminant(int[,] matrix, int n)
    {
        if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        int determinant = 0;
        for (int i = 0; i < n; i++)
        {
            determinant += matrix[0, i] * CalculateCofactor(matrix, 0, i, n) * (int)Math.Pow(-1, i);
        }

        return determinant;
    }

    static int CalculateCofactor(int[,] matrix, int row, int col, int n)
    {
        int[,] subMatrix = new int[n - 1, n - 1];
        int r = 0, c = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != row && j != col)
                {
                    subMatrix[r, c] = matrix[i, j];
                    c++;
                    if (c == n - 1)
                    {
                        r++;
                        c = 0;
                    }
                }
            }
        }

        return CalculateDeterminant(subMatrix, n - 1);
    }
}
