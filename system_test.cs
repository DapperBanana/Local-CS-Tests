
using System;

class Matrix
{
    private int rows;
    private int cols;
    private int[,] data;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        data = new int[rows, cols];
    }

    public void FillMatrix()
    {
        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int element = Convert.ToInt32(Console.ReadLine());
                data[i, j] = element;
            }
        }
    }

    public void DisplayMatrix()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(data[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public Matrix Add(Matrix matrix)
    {
        Matrix result = new Matrix(rows, cols);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result.data[i, j] = data[i, j] + matrix.data[i, j];
            }
        }
        return result;
    }

    public Matrix Subtract(Matrix matrix)
    {
        Matrix result = new Matrix(rows, cols);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result.data[i, j] = data[i, j] - matrix.data[i, j];
            }
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter dimensions of first matrix (rows cols):");
        string[] dim1 = Console.ReadLine().Split(' ');
        int rows1 = Convert.ToInt32(dim1[0]);
        int cols1 = Convert.ToInt32(dim1[1]);

        Console.WriteLine("Enter dimensions of second matrix (rows cols):");
        string[] dim2 = Console.ReadLine().Split(' ');
        int rows2 = Convert.ToInt32(dim2[0]);
        int cols2 = Convert.ToInt32(dim2[1]);

        if (rows1 != rows2 || cols1 != cols2)
        {
            Console.WriteLine("Matrix dimensions must match!");
            return;
        }

        Matrix matrix1 = new Matrix(rows1, cols1);
        Matrix matrix2 = new Matrix(rows2, cols2);

        Console.WriteLine("Enter elements for first matrix:");
        matrix1.FillMatrix();

        Console.WriteLine("Enter elements for second matrix:");
        matrix2.FillMatrix();

        Console.WriteLine("First matrix:");
        matrix1.DisplayMatrix();

        Console.WriteLine("Second matrix:");
        matrix2.DisplayMatrix();

        Matrix resultAdd = matrix1.Add(matrix2);
        Console.WriteLine("Matrix addition result:");
        resultAdd.DisplayMatrix();

        Matrix resultSubtract = matrix1.Subtract(matrix2);
        Console.WriteLine("Matrix subtraction result:");
        resultSubtract.DisplayMatrix();
    }
}
