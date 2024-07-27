
using System;
using System.Collections.Generic;

class Program
{
    static int[,] maze;
    static int width, height;

    static void Main()
    {
        Random rand = new Random();
        width = 10;
        height = 10;

        maze = GenerateMaze(width, height, rand);
        PrintMaze();

        List<Point> solution = FindSolution(maze, new Point(0, 0), new Point(width - 1, height - 1));
        if (solution.Count > 0)
        {
            Console.WriteLine("Solution found:");
            foreach (Point point in solution)
            {
                Console.WriteLine($"({point.X}, {point.Y})");
            }
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    static int[,] GenerateMaze(int width, int height, Random rand)
    {
        int[,] maze = new int[width, height];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                maze[i, j] = rand.Next(2); // 0 means wall, 1 means path
            }
        }

        return maze;
    }

    static void PrintMaze()
    {
        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write(maze[i, j] == 1 ? " " : "#");
            }
            Console.WriteLine();
        }
    }

    static List<Point> FindSolution(int[,] maze, Point start, Point end)
    {
        Queue<Point> queue = new Queue<Point>();
        queue.Enqueue(start);

        Dictionary<Point, Point> cameFrom = new Dictionary<Point, Point>();
        cameFrom[start] = start;

        while (queue.Count > 0)
        {
            Point current = queue.Dequeue();

            if (current.Equals(end))
            {
                List<Point> path = new List<Point>();
                while (!current.Equals(start))
                {
                    path.Add(current);
                    current = cameFrom[current];
                }
                path.Add(start);
                path.Reverse();
                return path;
            }

            foreach (Point neighbor in GetNeighbors(current, maze))
            {
                if (!cameFrom.ContainsKey(neighbor))
                {
                    queue.Enqueue(neighbor);
                    cameFrom[neighbor] = current;
                }
            }
        }

        return new List<Point>();
    }

    static List<Point> GetNeighbors(Point point, int[,] maze)
    {
        List<Point> neighbors = new List<Point>();

        if (point.X > 0 && maze[point.X - 1, point.Y] == 1)
            neighbors.Add(new Point(point.X - 1, point.Y));
        if (point.X < width - 1 && maze[point.X + 1, point.Y] == 1)
            neighbors.Add(new Point(point.X + 1, point.Y));
        if (point.Y > 0 && maze[point.X, point.Y - 1] == 1)
            neighbors.Add(new Point(point.X, point.Y - 1));
        if (point.Y < height - 1 && maze[point.X, point.Y + 1] == 1)
            neighbors.Add(new Point(point.X, point.Y + 1));

        return neighbors;
    }

    struct Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
                return false;
            Point other = (Point)obj;
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}
