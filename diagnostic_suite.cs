
using System;

class MagicTorusChecker
{
    static void Main()
    {
        int[,] matrix = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
        };

        bool isMagicTorus = CheckMagicTorus(matrix);

        if (isMagicTorus)
        {
            Console.WriteLine("The given matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic torus.");
        }
    }

    static bool CheckMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Calculate the magic sum
        int magicSum = n * (n * n + 1) / 2;

        // Check rows
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

        // Check columns
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
}
