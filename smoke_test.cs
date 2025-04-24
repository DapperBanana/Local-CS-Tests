
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private int width;
    private int height;
    private bool[,] maze;
    private Random rand;

    public MazeGenerator(int width, int height)
    {
        this.width = width;
        this.height = height;
        this.maze = new bool[width, height];
        this.rand = new Random();
    }

    public void GenerateMaze()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                maze[i, j] = rand.Next(2) == 0;
            }
        }
    }

    public List<Tuple<int, int>> FindSolution()
    {
        List<Tuple<int, int>> solution = new List<Tuple<int, int>>();
        int x = 0;
        int y = 0;

        while (x != width - 1 || y != height - 1)
        {
            solution.Add(new Tuple<int, int>(x, y));
            if (x < width - 1 && maze[x + 1, y])
            {
                x++;
            }
            else if (y < height - 1 && maze[x, y + 1])
            {
                y++;
            }
        }
        solution.Add(new Tuple<int, int>(width - 1, height - 1));

        return solution;
    }
}

class Program
{
    static void Main()
    {
        int width = 10;
        int height = 10;
        
        MazeGenerator mazeGenerator = new MazeGenerator(width, height);
        mazeGenerator.GenerateMaze();
        
        List<Tuple<int, int>> solution = mazeGenerator.FindSolution();
        
        Console.WriteLine("Maze Solution:");
        foreach (var point in solution)
        {
            Console.WriteLine($"({point.Item1}, {point.Item2})");
        }
    }
}
