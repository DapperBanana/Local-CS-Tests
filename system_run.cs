
using System;
using System.Collections.Generic;

class MazeSolver
{
    static int[,] maze = {
        { 1, 1, 1, 1, 1 },
        { 0, 0, 1, 1, 1 },
        { 1, 1, 1, 0, 1 },
        { 1, 0, 0, 0, 1 },
        { 1, 1, 1, 1, 1 }
    };

    static int[] dx = { 1, -1, 0, 0 };
    static int[] dy = { 0, 0, 1, -1 };

    static bool IsValidMove(int x, int y)
    {
        if (x < 0 || x >= maze.GetLength(0) || y < 0 || y >= maze.GetLength(1))
        {
            return false;
        }
        if (maze[x, y] == 0)
        {
            return false;
        }
        return true;
    }

    static bool SolveMaze(int x, int y)
    {
        if (x == maze.GetLength(0) - 1 && y == maze.GetLength(1) - 1)
        {
            return true; // Reached the end of the maze
        }

        maze[x, y] = 0; // Mark current position as visited

        for (int i = 0; i < 4; i++)
        {
            int newX = x + dx[i];
            int newY = y + dy[i];

            if (IsValidMove(newX, newY) && SolveMaze(newX, newY))
            {
                Console.WriteLine($"Move to ({newX}, {newY})");
                return true;
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        if (SolveMaze(0, 0))
        {
            Console.WriteLine("Maze solved!");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
