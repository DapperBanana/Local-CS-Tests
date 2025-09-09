
using System;

class Program
{
    static void Main()
    {
        int size = 3;
        
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        
        int determinant = CalculateDeterminant(matrix, size);
        Console.WriteLine("Determinant of the matrix is: " + determinant);
    }
    
    static int CalculateDeterminant(int[,] matrix, int size)
    {
        if(size == 1)
        {
            return matrix[0, 0];
        }
        else if(size == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else
        {
            int det = 0;
            for(int i = 0; i < size; i++)
            {
                int[,] submatrix = new int[size - 1, size - 1];
                for(int j = 1; j < size; j++)
                {
                    for(int k = 0; k < size; k++)
                    {
                        if(k < i)
                        {
                            submatrix[j - 1, k] = matrix[j, k];
                        }
                        else if(k > i)
                        {
                            submatrix[j - 1, k - 1] = matrix[j, k];
                        }
                    }
                }
                det += (int)Math.Pow(-1, i) * matrix[0, i] * CalculateDeterminant(submatrix, size - 1);
            }
            return det;
        }
    }
}
