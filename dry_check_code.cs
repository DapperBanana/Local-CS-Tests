
using System;

class MagicTorusChecker
{
    static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        
        // Check if all rows have the same sum
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            
            if (i == 0)
            {
                sum = rowSum;
            }
            else if (rowSum != sum)
            {
                return false;
            }
        }
        
        // Check if all columns have the same sum
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }
            
            if (colSum != sum)
            {
                return false;
            }
        }
        
        return true;
    }
    
    static void Main()
    {
        int[,] matrix = {
            {4, 9, 2},
            {3, 5, 7},
            {8, 1, 6}
        };
        
        bool isMagicTorus = IsMagicTorus(matrix);
        
        if (isMagicTorus)
        {
            Console.WriteLine("The given matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic torus.");
        }
    }
}
