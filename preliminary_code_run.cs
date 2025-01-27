
using System;

class Program
{
    static int[,] maze = {
        {1, 1, 1, 1, 1},
        {0, 0, 1, 0, 1},
        {1, 1, 1, 0, 1},
        {1, 0, 0, 0, 1},
        {1, 1, 1, 1, 1}
    };
    
    static int[,] visited = new int[5, 5];
    
    static int startRow = 1;
    static int startCol = 0;
    
    static int endRow = 3;
    static int endCol = 4;
    
    static void Main()
    {
        if (SolveMaze(startRow, startCol))
        {
            Console.WriteLine("Maze solved!");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
    
    static bool SolveMaze(int row, int col)
    {
        if (row < 0 || col < 0 || row >= 5 || col >= 5 || maze[row, col] == 0 || visited[row, col] == 1)
        {
            return false;
        }
        
        visited[row, col] = 1;
        
        if (row == endRow && col == endCol)
        {
            return true;
        }
        
        if (SolveMaze(row + 1, col) || SolveMaze(row - 1, col) || SolveMaze(row, col + 1) || SolveMaze(row, col - 1))
        {
            Console.WriteLine("Move to (" + row + "," + col + ")");
            return true;
        }
        
        return false;
    }
}
