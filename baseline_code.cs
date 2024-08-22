
using System;

class MagicSquareChecker
{
    static int checkMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, i];
        }

        int sumDiag = 0;
        for (int i = 0; i < n; i++)
        {
            sumDiag += matrix[i, n - 1 - i];
        }

        if (sum != sumDiag)
        {
            return 0;
        }

        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;
            int colSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
                colSum += matrix[j, i];
            }

            if (rowSum != sum || colSum != sum)
            {
                return 0;
            }
        }

        return 1;
    }

    static void Main()
    {
        int[,] matrix = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
        };

        if (checkMagicSquare(matrix) == 1)
        {
            Console.WriteLine("The given matrix is a magic square.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic square.");
        }
    }
}
