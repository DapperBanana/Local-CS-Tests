
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private int width;
    private int height;
    private char[,] maze;
    private Random random = new Random();

    public MazeGenerator(int width, int height)
    {
        this.width = width;
        this.height = height;
        this.maze = new char[height, width];
    }

    public void GenerateMaze()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                maze[i, j] = random.Next(2) == 0 ? '#' : ' ';
            }
        }

        maze[0, 0] = 'S'; // Start
        maze[height - 1, width - 1] = 'E'; // End
    }

    public void SolveMaze()
    {
        List<(int, int)> path = new List<(int, int)>();
        bool result = FindPath(0, 0, path);

        if (result)
        {
            foreach (var cell in path)
            {
                maze[cell.Item1, cell.Item2] = '+';
            }

            maze[0, 0] = 'S';
            maze[height - 1, width - 1] = 'E';
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    private bool FindPath(int x, int y, List<(int, int)> path)
    {
        if (x < 0 || x >= width || y < 0 || y >= height || maze[y, x] == '#' || maze[y, x] == '+')
        {
            return false;
        }

        path.Add((y, x));

        if (x == width - 1 && y == height - 1)
        {
            return true;
        }

        if (FindPath(x + 1, y, path) || FindPath(x, y + 1, path) || FindPath(x - 1, y, path) || FindPath(x, y - 1, path))
        {
            return true;
        }

        path.Remove((y, x));

        return false;
    }

    public void PrintMaze()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        MazeGenerator maze = new MazeGenerator(10, 10);
        maze.GenerateMaze();
        Console.WriteLine("Random Maze:");
        maze.PrintMaze();

        Console.WriteLine("\nSolution:");
        maze.SolveMaze();
        maze.PrintMaze();
    }
}
