
using System;
using System.Collections.Generic;

public class Maze
{
    private int rows;
    private int cols;
    private int[,] maze;
    private Random rand;

    public Maze(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        maze = new int[rows, cols];
        rand = new Random();
        GenerateMaze();
    }

    private void GenerateMaze()
    {
        // Initialize maze with walls
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = 1;
            }
        }

        // Generate random maze
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        int startX = rand.Next(rows);
        int startY = rand.Next(cols);
        maze[startX, startY] = 0;
        stack.Push(Tuple.Create(startX, startY));

        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Peek();
            int x = current.Item1;
            int y = current.Item2;
            List<Tuple<int, int>> neighbors = GetNeighbors(x, y);

            if (neighbors.Count == 0)
            {
                stack.Pop();
            }
            else
            {
                Tuple<int, int> next = neighbors[rand.Next(neighbors.Count)];
                int nextX = next.Item1;
                int nextY = next.Item2;
                maze[nextX, nextY] = 0;
                maze[x + (nextX - x) / 2, y + (nextY - y) / 2] = 0;
                stack.Push(Tuple.Create(nextX, nextY));
            }
        }
    }

    private List<Tuple<int, int>> GetNeighbors(int x, int y)
    {
        List<Tuple<int, int>> neighbors = new List<Tuple<int, int>>();

        if (x >= 2 && maze[x - 2, y] == 1)
        {
            neighbors.Add(Tuple.Create(x - 2, y));
        }
        if (x < rows - 2 && maze[x + 2, y] == 1)
        {
            neighbors.Add(Tuple.Create(x + 2, y));
        }
        if (y >= 2 && maze[x, y - 2] == 1)
        {
            neighbors.Add(Tuple.Create(x, y - 2));
        }
        if (y < cols - 2 && maze[x, y + 2] == 1)
        {
            neighbors.Add(Tuple.Create(x, y + 2));
        }

        neighbors.Shuffle(rand);
        return neighbors;
    }

    public void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] == 1 ? "#" : " ");
            }
            Console.WriteLine();
        }
    }

    public void SolveMaze()
    {
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        List<Tuple<int, int>> visited = new List<Tuple<int, int>>();
        Tuple<int, int> start = Tuple.Create(1, 1);
        Tuple<int, int> end = Tuple.Create(rows - 2, cols - 2);
        stack.Push(start);

        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Pop();
            int x = current.Item1;
            int y = current.Item2;
            visited.Add(current);

            if (current.Equals(end))
            {
                foreach (var point in visited)
                {
                    maze[point.Item1, point.Item2] = 2;
                }
                return;
            }

            List<Tuple<int, int>> neighbors = GetNeighbors(x, y);
            foreach (var neighbor in neighbors)
            {
                if (!visited.Contains(neighbor))
                {
                    stack.Push(neighbor);
                }
            }
        }
    }

    static void Main()
    {
        Maze maze = new Maze(21, 21);
        maze.PrintMaze();
        maze.SolveMaze();
        maze.PrintMaze();
    }
}

public static class Extensions
{
    public static void Shuffle<T>(this IList<T> list, Random random)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int j = random.Next(i, list.Count);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
