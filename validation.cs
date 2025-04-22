
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private int rows;
    private int cols;
    private char[,] maze;

    public MazeGenerator(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        this.maze = new char[rows, cols];
    }

    public void GenerateMaze()
    {
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = 'X';
            }
        }

        for (int i = 1; i < rows; i += 2)
        {
            for (int j = 1; j < cols; j += 2)
            {
                maze[i, j] = ' ';
                if (i == rows - 2 && j == cols - 2)
                {
                    break;
                }

                if (i == rows - 2 || (j != cols - 2 && rand.Next(2) == 0))
                {
                    maze[i, j + 1] = ' ';
                }
                else
                {
                    maze[i + 1, j] = ' ';
                }
            }
        }
    }

    public void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public bool FindPath(int x, int y)
    {
        if (x < 0 || x >= rows || y < 0 || y >= cols)
            return false;

        if (maze[x, y] == ' ' || maze[x, y] == 'S')
        {
            maze[x, y] = '.';

            if (x == rows - 1 && y == cols - 1)
            {
                maze[x, y] = 'E';
                return true;
            }

            if (FindPath(x + 1, y) || FindPath(x - 1, y) || FindPath(x, y + 1) || FindPath(x, y - 1))
            {
                return true;
            }

            maze[x, y] = ' ';
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        int rows = 21;
        int cols = 21;

        MazeGenerator maze = new MazeGenerator(rows, cols);
        maze.GenerateMaze();
        maze.maze[0, 0] = 'S';
        maze.maze[rows - 1, cols - 1] = 'E';

        Console.WriteLine("Random Maze:");
        maze.PrintMaze();

        if (maze.FindPath(0, 0))
        {
            Console.WriteLine("\nSolution:");
            maze.PrintMaze();
        }
        else
        {
            Console.WriteLine("\nNo solution found.");
        }
    }
}
