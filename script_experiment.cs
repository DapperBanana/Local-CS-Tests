
using System;

class MazeSolver
{
    static char[,] maze = {
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', '#' },
        { '#', '#', '#', ' ', '#', '#', '#', '#', ' ', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
        { '#', '#', '#', '#', '#', '#', ' ', '#', '#', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
    };

    static int startRow = 1;
    static int startCol = 1;

    static int endRow = 5;
    static int endCol = 10;

    static void Main()
    {
        if (SolveMaze(startRow, startCol))
        {
            Console.WriteLine("Maze solved!");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    static bool SolveMaze(int row, int col)
    {
        if (row < 0 || col < 0 || row >= maze.GetLength(0) || col >= maze.GetLength(1))
        {
            return false;
        }

        if (maze[row, col] == '#' || maze[row, col] == '*')
        {
            return false;
        }

        if (row == endRow && col == endCol)
        {
            maze[row, col] = '*';
            PrintMaze();
            return true;
        }

        maze[row, col] = '*';

        if (SolveMaze(row + 1, col) || SolveMaze(row - 1, col) || SolveMaze(row, col + 1) || SolveMaze(row, col - 1))
        {
            return true;
        }

        maze[row, col] = ' ';
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
