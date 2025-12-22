using System;

class MazeGeneratorAndSolver
{
    static int width = 20;
    static int height = 10;
    static int[,] maze = new int[height, width];

    static void Main()
    {
        GenerateMaze();
        Console.WriteLine("Generated Maze:");
        PrintMaze();

        Console.WriteLine("\nSolving Maze:");
        if (SolveMaze(1, 1))
        {
            PrintMaze(solutionPath: true);
        }
        else
        {
            Console.WriteLine("No path found!");
        }
    }

    static void GenerateMaze()
    {
        // Initialize maze - walls (0) on all cells
        for (int y = 0; y < height; y++)
            for (int x = 0; x < width; x++)
                maze[y, x] = 0;

        Random rand = new Random();

        // Recursive backtracking maze generation
        void CarvePath(int x, int y)
        {
            var directions = new (int dx, int dy)[]
            {
                (0, -2), // up
                (2, 0),  // right
                (0, 2),  // down
                (-2, 0)  // left
            };

            // Shuffle directions
            for (int i = directions.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                var temp = directions[i];
                directions[i] = directions[j];
                directions[j] = temp;
            }

            foreach (var (dx, dy) in directions)
            {
                int nx = x + dx;
                int ny = y + dy;

                if (nx > 0 && nx < width - 1 && ny > 0 && ny < height - 1)
                {
                    if (maze[ny, nx] == 0)
                    {
                        maze[ny, nx] = 1; // Path
                        maze[y + dy / 2, x + dx / 2] = 1; // Remove wall between
                        CarvePath(nx, ny);
                    }
                }
            }
        }

        // Starting point
        maze[1, 1] = 1;
        CarvePath(1, 1);
    }

    static bool[,] visited = new bool[height, width];
    static bool pathFound = false;
    static (int x, int y)[] directions = new (int, int)[]
    {
        (0, -1), // up
        (1, 0),  // right
        (0, 1),  // down
        (-1, 0)  // left
    };
    static System.Collections.Generic.List<(int x, int y)> solution;

    static bool SolveMaze(int x, int y)
    {
        if (x < 0 || x >= width || y < 0 || y >= height)
            return false;
        if (maze[y, x] == 0 || visited[y, x])
            return false;

        if (x == width - 2 && y == height - 2) // goal
        {
            if (solution == null) solution = new System.Collections.Generic.List<(int, int)>();
            solution.Add((x, y));
            return true;
        }

        visited[y, x] = true;

        foreach (var (dx, dy) in directions)
        {
            int nx = x + dx;
            int ny = y + dy;

            if (SolveMaze(nx, ny))
            {
                if (solution == null) solution = new System.Collections.Generic.List<(int, int)>();
                solution.Add((x, y));
                return true;
            }
        }
        return false;
    }

    static void PrintMaze(bool solutionPath = false)
    {
        bool[,] displaySolution = new bool[height, width];
        if (solutionPath && solution != null)
        {
            foreach (var (x, y) in solution)
            {
                displaySolution[y, x] = true;
            }
        }

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (displaySolution[y, x])
                {
                    Console.Write("*");
                }
                else if (maze[y, x] == 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }
}