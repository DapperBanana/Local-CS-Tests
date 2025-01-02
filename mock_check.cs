
using System;

class MagicTorus
{
    static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        
        // Check if rows sum to the same value
        int expectedSum = 0;
        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            if (expectedSum == 0)
            {
                expectedSum = rowSum;
            }
            if (rowSum != expectedSum)
            {
                return false;
            }
        }
        
        // Check if columns sum to the same value
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }
            if (colSum != expectedSum)
            {
                return false;
            }
        }
        
        return true;
    }
    
    static void Main()
    {
        int[,] matrix = { { 32, 9, 3 },
                          { 2, 25, 14 },
                          { 6, 12, 20 } };
        
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
