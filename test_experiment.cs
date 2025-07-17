
using System;

class MazeSolver
{
    static char[,] maze = {
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
        { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', ' ', '#' },
        { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
        { '#', ' ', '#', '#', '#', ' ', '#', '#', '#', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
        { '#', '#', '#', ' ', '#', '#', '#', '#', '#', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', 'E', '#' },
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    };

    static void Main()
    {
        PrintMaze();

        if (SolveMaze(1, 1))
        {
            Console.WriteLine("Maze solved!");
        }
        else
        {
            Console.WriteLine("Maze cannot be solved!");
        }
    }

    static bool SolveMaze(int row, int col)
    {
        if (maze[row, col] == 'E')
        {
            return true;
        }

        if (maze[row, col] == ' ' || maze[row, col] == 'S')
        {
            maze[row, col] = '.';

            if (SolveMaze(row + 1, col) || SolveMaze(row, col + 1) || SolveMaze(row - 1, col) || SolveMaze(row, col - 1))
            {
                return true;
            }

            maze[row, col] = ' ';
        }

        return false;
    }

    static void PrintMaze()
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
