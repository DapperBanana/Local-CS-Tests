
using System;

class MatrixOperations
{
    static void Main()
    {
        int rows, cols;

        // Get the dimensions of the matrix from the user
        Console.WriteLine("Enter the number of rows in the matrix: ");
        rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns in the matrix: ");
        cols = int.Parse(Console.ReadLine());

        // Create two matrices with the provided dimensions
        int[,] matrix1 = new int[rows, cols];
        int[,] matrix2 = new int[rows, cols];
        int[,] resultMatrix = new int[rows, cols];

        // Input values for the first matrix
        Console.WriteLine("Enter values for the first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Input values for the second matrix
        Console.WriteLine("Enter values for the second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Perform addition of the two matrices
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        // Display the result of addition
        Console.WriteLine("Result of addition:");
        DisplayMatrix(resultMatrix);

        // Perform subtraction of the two matrices
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        // Display the result of subtraction
        Console.WriteLine("Result of subtraction:");
        DisplayMatrix(resultMatrix);
    }

    static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
