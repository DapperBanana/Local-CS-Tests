
using System;

class MagicTorusChecker
{
    static void Main()
    {
        int[,] matrix = {
            { 16, 3, 2, 13 },
            { 5, 10, 11, 8 },
            { 9, 6, 7, 12 },
            { 4, 15, 14, 1 }
        };

        if (CheckMagicTorus(matrix))
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
        int magicSum = n * (n * n + 1) / 2;

        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;
            int colSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
                colSum += matrix[j, i];
            }

            if (rowSum != magicSum || colSum != magicSum)
            {
                return false;
            }
        }

        return true;
    }
}
