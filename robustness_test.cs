
using System;

class Matrix
{
    public static bool IsInvertible(double[,] mat)
    {
        if (mat.GetLength(0) != mat.GetLength(1))
            return false;

        int n = mat.GetLength(0);
        double[,] temp = new double[n, n];
        double det = Determinant(mat, n);

        if (det == 0)
            return false;
        
        return true;
    }

    public static double Determinant(double[,] mat, int n)
    {
        double det = 0;
        double[,] temp = new double[n, n];
        int sign = 1;

        if (n == 1)
            return mat[0, 0];

        for (int f = 0; f < n; f++)
        {
            GetCofactor(mat, temp, 0, f, n);
            det += sign * mat[0, f] * Determinant(temp, n - 1);
            sign = -sign;
        }

        return det;
    }

    public static void GetCofactor(double[,] mat, double[,] temp, int p, int q, int n)
    {
        int i = 0, j = 0;

        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if (r != p && c != q)
                {
                    temp[i, j++] = mat[r, c];
                    if (j == n - 1)
                    {
                        j = 0;
                        i++;
                    }
                }
            }
        }
    }

    static void Main()
    {
        double[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        if (IsInvertible(matrix))
            Console.WriteLine("Matrix is invertible.");
        else
            Console.WriteLine("Matrix is not invertible.");
    }
}
