
using System;

class MagicTorusChecker
{
    static bool CheckMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        
        // Calculate the sum of the first row
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += matrix[0, j];
        }
        
        // Check all rows
        for (int i = 1; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            
            if (rowSum != sum)
            {
                return false;
            }
        }
        
        // Check all columns
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
        
        // Check the main diagonal
        int diagSum = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum += matrix[i, i];
        }
        if (diagSum != sum)
        {
            return false;
        }
        
        // Check the secondary diagonal
        diagSum = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum += matrix[i, n - 1 - i];
        }
        if (diagSum != sum)
        {
            return false;
        }
        
        return true;
    }
    
    static void Main()
    {
        int[,] matrix = {
            {16, 3, 2, 13},
            {5, 10, 11, 8},
            {9, 6, 7, 12},
            {4, 15, 14, 1}
        };
        
        if (CheckMagicTorus(matrix))
        {
            Console.WriteLine("The matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("The matrix is not a magic torus.");
        }
    }
}
