
using System;

class Program
{
    static void Main()
    {
        int n, m, i, j;
        bool symmetric = true;

        // Get the dimensions of the matrix from the user
        Console.WriteLine("Enter the number of rows: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of columns: ");
        m = Convert.ToInt32(Console.ReadLine());

        // Create a 2D array to store the matrix
        int[,] matrix = new int[n, m];

        // Get the elements of the matrix from the user
        Console.WriteLine("Enter the elements of the matrix: ");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Check if the matrix is symmetric
        if (n != m)
        {
            symmetric = false;
        }
        else
        {
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        symmetric = false;
                        break;
                    }
                }
                if (!symmetric)
                {
                    break;
                }
            }
        }

        // Display the result
        if (symmetric)
        {
            Console.WriteLine("The matrix is symmetric.");
        }
        else
        {
            Console.WriteLine("The matrix is not symmetric.");
        }
    }
}
