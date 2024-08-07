
using System;

class Program
{
    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int sum = 0;
        
        // Calculate the sum of the first row
        for (int j = 0; j < n; j++)
        {
            sum += matrix[0, j];
        }
        
        // Check rows
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
        
        // Check columns
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
        
        // Check diagonal
        int diagSum = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum += matrix[i, i];
        }
        
        if (diagSum != sum)
        {
            return false;
        }
        
        // Check anti-diagonal
        int antiDiagSum = 0;
        for (int i = 0; i < n; i++)
        {
            antiDiagSum += matrix[i, n - 1 - i];
        }
        
        if (antiDiagSum != sum)
        {
            return false;
        }
        
        return true;
    }
    
    static void Main()
    {
        int[,] matrix = {
            { 2, 7, 6 },
	        { 9, 5, 1 },
	        { 4, 3, 8 }
        };
        
        if (IsMagicSquare(matrix))
        {
            Console.WriteLine("The given matrix is a magic square");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic square");
        }
    }
}
