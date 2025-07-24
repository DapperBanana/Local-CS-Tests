
using System;

class MatrixOrthogonality
{
    static void Main()
    {
        double[,] matrix = { 
            { 1, 0, 0 }, 
            { 0, 1, 0 }, 
            { 0, 0, 1 } 
        };

        bool isOrthogonal = CheckOrthogonality(matrix);
        
        if (isOrthogonal)
        {
            Console.WriteLine("The given matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("The given matrix is not orthogonal.");
        }
    }

    static bool CheckOrthogonality(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                double dotProduct = 0;
                
                for (int k = 0; k < rows; k++)
                {
                    dotProduct += matrix[i, k] * matrix[j, k];
                }

                if (Math.Abs(dotProduct) > 1e-6)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
