
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private int width;
    private int height;
    private char[,] maze;

    public MazeGenerator(int width, int height)
    {
        this.width = width;
        this.height = height;
        this.maze = new char[width, height];
    }

    public void GenerateMaze()
    {
        Random rnd = new Random();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                maze[i, j] = rnd.Next(0, 2) == 0 ? '#' : ' ';
            }
        }
        maze[0, 0] = 'S';
        maze[width - 1, height - 1] = 'E';
    }

    public void SolveMaze()
    {
        if (DepthFirstSearch(0, 0))
        {
            maze[0, 0] = 'S';
            maze[width - 1, height - 1] = 'E';

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(maze[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    private bool DepthFirstSearch(int x, int y)
    {
        if (x < 0 || y < 0 || x >= width || y >= height || maze[x, y] == '#' || maze[x, y] == 'V')
        {
            return false;
        }

        maze[x, y] = 'V';
        if (maze[x, y] == 'E')
        {
            return true;
        }

        if (DepthFirstSearch(x + 1, y) || DepthFirstSearch(x - 1, y) || DepthFirstSearch(x, y + 1) || DepthFirstSearch(x, y - 1))
        {
            maze[x, y] = 'X';
            return true;
        }

        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MazeGenerator maze = new MazeGenerator(10, 10);
        maze.GenerateMaze();
        maze.SolveMaze();
    }
}
