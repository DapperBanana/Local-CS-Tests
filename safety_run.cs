
using System;

class MagicTorusCheck
{
    static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int rowSum = 0;
        int colSum = 0;
        int diag1Sum = 0;
        int diag2Sum = 0;

        // Calculate the sum of the first row and first column
        for (int i = 0; i < n; i++)
        {
            rowSum += matrix[0, i];
            colSum += matrix[i, 0];
        }

        // Calculate the sum of the main diagonal and the anti-diagonal
        for (int i = 0; i < n; i++)
        {
            diag1Sum += matrix[i, i];
            diag2Sum += matrix[i, n - 1 - i];
        }

        // Check if the sums are equal
        if (rowSum == colSum && colSum == diag1Sum && diag1Sum == diag2Sum)
        {
            return true;
        }
        return false;
    }

    static void Main()
    {
        int[,] matrix = {
            { 16, 3, 2, 13 },
            { 5, 10, 11, 8 },
            { 9, 6, 7, 12 },
            { 4, 15, 14, 1 }
        };

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
