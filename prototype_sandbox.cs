
using System;
using System.Collections.Generic;

class Program
{
    static void Dijkstra(int[,] graph, int source, int vertices)
    {
        int[] distance = new int[vertices];
        bool[] visited = new bool[vertices];

        for (int i = 0; i < vertices; i++)
        {
            distance[i] = int.MaxValue;
            visited[i] = false;
        }

        distance[source] = 0;

        for (int count = 0; count < vertices - 1; count++)
        {
            int minDistance = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < vertices; i++)
            {
                if (!visited[i] && distance[i] < minDistance)
                {
                    minDistance = distance[i];
                    minIndex = i;
                }
            }

            visited[minIndex] = true;

            for (int i = 0; i < vertices; i++)
            {
                if (!visited[i] && graph[minIndex,i] != 0 && distance[minIndex] != int.MaxValue && distance[minIndex] + graph[minIndex,i] < distance[i])
                {
                    distance[i] = distance[minIndex] + graph[minIndex,i];
                }
            }
        }

        Console.WriteLine("Shortest Distance from Source to other Vertices:");

        for (int i = 0; i < vertices; i++)
        {
            Console.WriteLine($"Vertex {i}: {distance[i]}");
        }
    }

    public static void Main()
    {
        int[,] graph = {
            {0, 4, 0, 0, 0, 0, 0, 8, 0},
            {4, 0, 8, 0, 0, 0, 0, 11, 0},
            {0, 8, 0, 7, 0, 4, 0, 0, 2},
            {0, 0, 7, 0, 9, 14, 0, 0, 0},
            {0, 0, 0, 9, 0, 10, 0, 0, 0},
            {0, 0, 4, 14, 10, 0, 2, 0, 0},
            {0, 0, 0, 0, 0, 2, 0, 1, 6},
            {8, 11, 0, 0, 0, 0, 1, 0, 7},
            {0, 0, 2, 0, 0, 0, 6, 7, 0}
        };

        Dijkstra(graph, 0, 9);
    }
}
