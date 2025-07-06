
using System;

class MainClass {
    public static void Main(string[] args) {
        int[,] matrix = {
            {1, 0, 0},
            {0, 1, 0},
            {0, 0, 1}
        };

        bool isOrthogonal = IsOrthogonal(matrix);
        
        if(isOrthogonal) {
            Console.WriteLine("The matrix is orthogonal.");
        } else {
            Console.WriteLine("The matrix is not orthogonal.");
        }
    }

    public static bool IsOrthogonal(int[,] matrix) {
        // Check if the matrix is square
        if(matrix.GetLength(0) != matrix.GetLength(1)) {
            throw new ArgumentException("Matrix must be square");
        }
        
        // Check if the matrix is orthogonal
        for(int i = 0; i < matrix.GetLength(0); i++) {
            for(int j = 0; j < matrix.GetLength(0); j++) {
                int dotProduct = 0;
                for(int k = 0; k < matrix.GetLength(0); k++) {
                    dotProduct += matrix[i,k] * matrix[j,k];
                }
                
                if(i == j && dotProduct != 1) {
                    return false;
                } else if(i != j && dotProduct != 0) {
                    return false;
                }
            }
        }
        
        return true;
    }
}
