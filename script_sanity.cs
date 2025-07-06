
using System;
using System.Collections.Generic;

class Maze
{
    private int rows;
    private int cols;
    private int[,] maze;
    private bool[,] visited;

    public Maze(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        maze = new int[rows, cols];
        visited = new bool[rows, cols];
        GenerateMaze();
    }

    private void GenerateMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = 1;
                visited[i, j] = false;
            }
        }

        Random rand = new Random();
        Stack<(int, int)> stack = new Stack<(int, int)>();
        int startX = rand.Next(rows);
        int startY = rand.Next(cols);
        stack.Push((startX, startY));
        visited[startX, startY] = true;

        while (stack.Count > 0)
        {
            (int x, int y) = stack.Peek();
            List<(int, int)> neighbors = GetNeighbors(x, y);
            if (neighbors.Count > 0)
            {
                (int nx, int ny) = neighbors[rand.Next(neighbors.Count)];
                visited[nx, ny] = true;
                maze[nx, ny] = 0;
                stack.Push((nx, ny));
            }
            else
            {
                stack.Pop();
            }
        }
    }

    private List<(int, int)> GetNeighbors(int x, int y)
    {
        List<(int, int)> neighbors = new List<(int, int)>();

        if (x - 2 >= 0 && !visited[x - 2, y])
        {
            neighbors.Add((x - 2, y));
        }
        if (x + 2 < rows && !visited[x + 2, y])
        {
            neighbors.Add((x + 2, y));
        }
        if (y - 2 >= 0 && !visited[x, y - 2])
        {
            neighbors.Add((x, y - 2));
        }
        if (y + 2 < cols && !visited[x, y + 2])
        {
            neighbors.Add((x, y + 2));
        }

        return neighbors;
    }

    public void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] == 0 ? " " : "#");
            }
            Console.WriteLine();
        }
    }

    public void FindSolution()
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((0, 0));

        while (queue.Count > 0)
        {
            (int x, int y) = queue.Dequeue();
            if (x == rows - 1 && y == cols - 1)
            {
                Console.WriteLine("Solution found!");
                return;
            }

            visited[x, y] = true;

            List<(int, int)> neighbors = GetNeighbors(x, y);
            foreach ((int nx, int ny) in neighbors)
            {
                if (!visited[nx, ny])
                {
                    queue.Enqueue((nx, ny));
                }
            }
        }

        Console.WriteLine("No solution found!");
    }
}

class Program
{
    static void Main()
    {
        Maze maze = new Maze(10, 10);
        Console.WriteLine("Random Maze:");
        maze.PrintMaze();
        Console.WriteLine("Finding solution...");
        maze.FindSolution();
    }
}
