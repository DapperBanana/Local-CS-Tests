
using System;

class MagicTorusChecker
{
    static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
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

    static bool IsMagicTorus(int[][] matrix)
    {
        int n = matrix.Length;
        
        int[] rowSums = new int[n];
        int[] colSums = new int[n];
        int diagSum = 0;
        int revDiagSum = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rowSums[i] += matrix[i][j];
                colSums[j] += matrix[i][j];
                
                if (i == j)
                {
                    diagSum += matrix[i][j];
                }
                
                if (i + j == n - 1)
                {
                    revDiagSum += matrix[i][j];
                }
            }
        }
        
        int magicNumber = rowSums[0];
        
        for (int i = 0; i < n; i++)
        {
            if (rowSums[i] != magicNumber || colSums[i] != magicNumber)
            {
                return false;
            }
        }
        
        if (diagSum != magicNumber || revDiagSum != magicNumber)
        {
            return false;
        }
        
        return true;
    }
}
