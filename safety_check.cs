
using System;

class MagicTorusChecker
{
    static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] { 2, 7, 6 },
            new int[] { 9, 5, 1 },
            new int[] { 4, 3, 8 }
        };

        Console.WriteLine("Checking if the given matrix is a magic torus...");

        if(IsMagicTorus(matrix))
        {
            Console.WriteLine("The given matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic torus.");
        }
    }

    static bool IsMagicTorus(int[][] matrix)
    {
        int rowSum = 0, colSum = 0, diagSum1 = 0, diagSum2 = 0;

        for(int i = 0; i < matrix.Length; i++)
        {
            int rowTotal = 0;
            int colTotal = 0;

            for(int j = 0; j < matrix[i].Length; j++)
            {
                rowTotal += matrix[i][j];
                colTotal += matrix[j][i];
                if(i == j)
                {
                    diagSum1 += matrix[i][j];
                }
                if(i + j == matrix.Length - 1)
                {
                    diagSum2 += matrix[i][j];
                }
            }

            if(i == 0)
            {
                rowSum = rowTotal;
                colSum = colTotal;
            }
            else
            {
                if(rowSum != rowTotal || colSum != colTotal)
                {
                    return false;
                }
            }
        }

        return rowSum == colSum && colSum == diagSum1 && diagSum1 == diagSum2;
    }
}
