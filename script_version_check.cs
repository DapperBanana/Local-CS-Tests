
using System;
using System.Collections.Generic;

class Program
{
    static int rows = 10;
    static int cols = 10;
    static char[,] maze = new char[rows, cols];
    static bool[,] visited = new bool[rows, cols];

    static void Main(string[] args)
    {
        GenerateMaze();
        PrintMaze();
        FindSolution();
        PrintMaze();
    }

    static void GenerateMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = 'X';
                visited[i, j] = false;
            }
        }

        visited[0, 0] = true;
        maze[0, 0] = 'S';

        Random rand = new Random();
        DFS(rand.Next(0, rows), rand.Next(0, cols));
        maze[rows - 1, cols - 1] = 'E';
    }

    static void DFS(int x, int y)
    {
        List<(int, int)> directions = new List<(int, int)> { (-1, 0), (1, 0), (0, -1), (0, 1) };
        Shuffle(directions);

        foreach (var (dx, dy) in directions)
        {
            int newX = x + dx;
            int newY = y + dy;

            if (newX >= 0 && newX < rows && newY >= 0 && newY < cols && !visited[newX, newY])
            {
                visited[newX, newY] = true;
                maze[newX, newY] = ' ';
                DFS(newX, newY);
            }
        }
    }

    static void Shuffle<T>(List<T> list)
    {
        Random rand = new Random();
        for (int i = 0; i < list.Count; i++)
        {
            int randomIndex = rand.Next(i, list.Count);
            T temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    static void FindSolution()
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((0, 0));

        while (queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();

            foreach (var (dx, dy) in new List<(int, int)> { (-1, 0), (1, 0), (0, -1), (0, 1) })
            {
                int newX = x + dx;
                int newY = y + dy;

                if (newX >= 0 && newX < rows && newY >= 0 && newY < cols && !visited[newX, newY])
                {
                    visited[newX, newY] = true;
                    if (maze[newX, newY] != 'E')
                    {
                        maze[newX, newY] = '.';
                    }
                    queue.Enqueue((newX, newY));
                }
            }
        }
    }

    static void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
