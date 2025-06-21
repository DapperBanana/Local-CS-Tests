
using System;

class Program
{
    static int[,] maze = new int[5,5] {
        {1, 0, 1, 1, 1},
        {1, 1, 1, 0, 1},
        {0, 1, 0, 1, 1},
        {1, 1, 1, 0, 0},
        {1, 0, 1, 1, 1}
    };

    static int mazeSize = 5;

    static bool SolveMaze(int x, int y)
    {
        if (x < 0 || x >= mazeSize || y < 0 || y >= mazeSize || maze[x, y] == 0)
        {
            return false;
        }

        if (x == mazeSize - 1 && y == mazeSize - 1)
        {
            return true;
        }

        maze[x, y] = 0; // Mark current cell as visited

        if (SolveMaze(x + 1, y) || SolveMaze(x, y + 1) || SolveMaze(x - 1, y) || SolveMaze(x, y - 1))
        {
            return true;
        }

        return false;
    }

    static void Main(string[] args)
    {
        if (SolveMaze(0, 0))
        {
            Console.WriteLine("The maze has a solution.");
        }
        else
        {
            Console.WriteLine("No solution found for the maze.");
        }
    }
}
