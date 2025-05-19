
using System;

class MagicTorusChecker
{
    static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int magicSum = 0;

        // Calculate the magic sum
        for (int i = 0; i < n; i++)
        {
            magicSum += matrix[0, i];
        }

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
        for (int i = 0; i < n; i++)
        {
            int colSum = 0;
            for (int j = 0; j < n; j++)
            {
                colSum += matrix[j, i];
            }
            if (colSum != magicSum)
            {
                return false;
            }
        }

        // Check diagonals
        int topLeftBottomRightSum = 0;
        int topRightBottomLeftSum = 0;
        for (int i = 0; i < n; i++)
        {
            topLeftBottomRightSum += matrix[i, i];
            topRightBottomLeftSum += matrix[i, n - 1 - i];
        }
        if (topLeftBottomRightSum != magicSum || topRightBottomLeftSum != magicSum)
        {
            return false;
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = new int[,] { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } };

        if (IsMagicTorus(matrix))
        {
            Console.WriteLine("The given matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic torus.");
        }
    }
}
