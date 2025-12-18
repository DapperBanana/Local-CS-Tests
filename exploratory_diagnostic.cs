using System;

class MazeSolver
{
    static char[,] maze = {
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
        { '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
        { '#', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', '#' },
        { '#', ' ', '#', '#', '#', '#', ' ', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#' },
        { '#', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#' },
        { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
        { '#', '#', ' ', '#', '#', '#', '#', '#', ' ', '#' },
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
    };

    static int rows = maze.GetLength(0);
    static int cols = maze.GetLength(1);

    static (int, int) start = (1,1);
    static (int, int) end = (8,8);

    static bool solved = false;

    static void Main()
    {
        Console.WriteLine("Maze:");
        PrintMaze();

        if (SolveMaze(start.Item1, start.Item2))
        {
            Console.WriteLine("Maze solved:");
            PrintMaze();
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    static bool SolveMaze(int row, int col)
    {
        // Check bounds and if cell is wall or visited
        if (row < 0 || col < 0 || row >= rows || col >= cols)
            return false;
        if (maze[row, col] == '#' || maze[row, col] == '.')
            return false;

        // Mark current position as part of path
        if ((row, col) == end)
        {
            maze[row, col] = 'o'; // mark end
            return true;
        }

        maze[row, col] = '.'; // mark as visited

        // Explore neighbors: up, right, down, left
        if (SolveMaze(row - 1, col) || // up
            SolveMaze(row, col + 1) || // right
            SolveMaze(row + 1, col) || // down
            SolveMaze(row, col - 1))   // left
        {
            maze[row, col] = 'o'; // mark path
            return true;
        }

        // Backtrack
        maze[row, col] = ' ';
        return false;
    }

    static void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}