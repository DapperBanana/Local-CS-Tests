
using System;

class MazeSolver
{
    static void Main()
    {
        char[,] maze = { // Represents the maze where 'S' is the start, 'E' is the exit, '#' is a wall, and '.' is an open space
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
            {'#', 'S', '#', '.', '.', '.', '#', '.', '.', '#'},
            {'#', '.', '#', '.', '#', '.', '#', '.', '#', '#'},
            {'#', '.', '.', '.', '#', '.', '.', '.', '.', '#'},
            {'#', '#', '#', '#', '#', '#', '#', '#', '.', '#'},
            {'#', '.', '.', '.', '.', '#', '.', '.', '.', '#'},
            {'#', '#', '#', '#', '.', '#', '#', '#', '#', '#'},
            {'#', '.', '.', '.', '.', '.', '.', '#', 'E', '#'},
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
        };

        if (SolveMaze(maze, 1, 1))
        {
            PrintMaze(maze);
            Console.WriteLine("Maze solved!");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    static bool SolveMaze(char[,] maze, int row, int col)
    {
        if (maze[row, col] == 'E')
        {
            return true;
        }

        if (maze[row, col] != '.' && maze[row, col] != 'S')
        {
            return false;
        }

        maze[row, col] = 'x'; // Mark the current position as visited

        // Recursively try moving in all directions
        if (SolveMaze(maze, row + 1, col) ||
            SolveMaze(maze, row - 1, col) ||
            SolveMaze(maze, row, col + 1) ||
            SolveMaze(maze, row, col - 1))
        {
            return true;
        }

        maze[row, col] = '.'; // Unmark the current position

        return false;
    }

    static void PrintMaze(char[,] maze)
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
