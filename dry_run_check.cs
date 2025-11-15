
using System;

class MagicTorusChecker
{
    public static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Check if all rows have the same sum
        int rowSum = 0;
        for (int i = 0; i < n; i++)
        {
            int currentRowSum = 0;
            for (int j = 0; j < n; j++)
            {
                currentRowSum += matrix[i, j];
            }
            if (i == 0)
            {
                rowSum = currentRowSum;
            }
            else if (rowSum != currentRowSum)
            {
                return false;
            }
        }

        // Check if all columns have the same sum
        int colSum = 0;
        for (int j = 0; j < n; j++)
        {
            int currentColSum = 0;
            for (int i = 0; i < n; i++)
            {
                currentColSum += matrix[i, j];
            }
            if (j == 0)
            {
                colSum = currentColSum;
            }
            else if (colSum != currentColSum)
            {
                return false;
            }
        }

        // Check if both diagonals have the same sum
        int diagSum1 = 0;
        int diagSum2 = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum1 += matrix[i, i];
            diagSum2 += matrix[i, n - i - 1];
        }

        return rowSum == colSum && colSum == diagSum1 && diagSum1 == diagSum2;
    }

    static void Main()
    {
        int[,] matrix = {
            { 4, 9, 2 },
            { 3, 5, 7 },
            { 8, 1, 6 }
        };

        bool isMagicTorus = IsMagicTorus(matrix);
        Console.WriteLine("Is this matrix a magic torus? " + isMagicTorus);
    }
}
