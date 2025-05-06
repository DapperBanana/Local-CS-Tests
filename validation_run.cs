
using System;

class MatrixInvertibility
{
    static void Main()
    {
        // Define the matrix
        double[,] matrix = {
            {2, 1},
            {4, 3}
        };

        // Check if the matrix is invertible
        bool isInvertible = IsInvertible(matrix);

        if (isInvertible)
        {
            Console.WriteLine("The matrix is invertible.");
        }
        else
        {
            Console.WriteLine("The matrix is not invertible.");
        }
    }

    static bool IsInvertible(double[,] matrix)
    {
        // Get the determinant of the matrix
        double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        // Return true if the determinant is not zero
        return det != 0;
    }
}
