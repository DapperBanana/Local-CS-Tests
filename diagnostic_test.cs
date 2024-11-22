
using System;

class Program
{
    public static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int magicSum = n * (n * n + 1) / 2;
        
        // Check rows sum
        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            if (rowSum != magicSum)
            {
                return false;
            }
        }

        // Check columns sum
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }
            if (colSum != magicSum)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = {
            { 4, 9, 2 },
            { 3, 5, 7 },
            { 8, 1, 6 }
        };

        if (IsMagicTorus(matrix))
        {
            Console.WriteLine("The matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("The matrix is not a magic torus.");
        }
    }
}
