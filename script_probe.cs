
using System;

class MagicTorus
{
    static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Calculate the target sum
        int targetSum = n * (n * n + 1) / 2;

        // Check rows
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += matrix[i, j];
            }
            if (sum != targetSum)
            {
                return false;
            }
        }

        // Check columns
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, j];
            }
            if (sum != targetSum)
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
