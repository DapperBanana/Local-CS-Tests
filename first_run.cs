
using System;

class MatrixReverse
{
    static void Main()
    {
        int rows, cols;

        Console.Write("Enter the number of rows in the matrix: ");
        rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of columns in the matrix: ");
        cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        ReverseMatrix(matrix);

        Console.WriteLine("Matrix after reversing rows and columns:");
        PrintMatrix(matrix);
    }

    static void ReverseMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows / 2; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[rows - i - 1, j];
                matrix[rows - i - 1, j] = temp;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, cols - j - 1];
                matrix[i, cols - j - 1] = temp;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
