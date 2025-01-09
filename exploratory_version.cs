
using System;

class MagicSquareChecker
{
    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        
        // Calculate the sum of the first row
        int targetSum = 0;
        for (int j = 0; j < n; j++)
        {
            targetSum += matrix[0, j];
        }
        
        // Check the sum of rows
        for (int i = 1; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            
            if (rowSum != targetSum)
            {
                return false;
            }
        }
        
        // Check the sum of columns
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }
            
            if (colSum != targetSum)
            {
                return false;
            }
        }
        
        // Check the sum of diagonals
        int diagonal1Sum = 0;
        int diagonal2Sum = 0;
        for (int i = 0; i < n; i++)
        {
            diagonal1Sum += matrix[i, i];
            diagonal2Sum += matrix[i, n - i - 1];
        }
        
        if (diagonal1Sum != targetSum || diagonal2Sum != targetSum)
        {
            return false;
        }
        
        return true;
    }

    static void Main()
    {
        int[,] matrix = new int[,]
        {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
        };

        if (IsMagicSquare(matrix))
        {
            Console.WriteLine("The given matrix is a magic square.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic square.");
        }
    }
}
