
using System;
using System.Collections.Generic;

public class DijkstraAlgorithm
{
    public static int[] Dijkstra(int[,] graph, int source)
    {
        int numNodes = graph.GetLength(0);
        int[] dist = new int[numNodes];
        bool[] visited = new bool[numNodes];

        for (int i = 0; i < numNodes; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
        }

        dist[source] = 0;

        for (int i = 0; i < numNodes - 1; i++)
        {
            int minDist = int.MaxValue;
            int minIndex = -1;

            for (int j = 0; j < numNodes; j++)
            {
                if (!visited[j] && dist[j] < minDist)
                {
                    minDist = dist[j];
                    minIndex = j;
                }
            }

            visited[minIndex] = true;

            for (int j = 0; j < numNodes; j++)
            {
                if (!visited[j] && graph[minIndex, j] != 0 && dist[minIndex] + graph[minIndex, j] < dist[j])
                {
                    dist[j] = dist[minIndex] + graph[minIndex, j];
                }
            }
        }

        return dist;
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
            {0, 0, 2, 0, 0, 0, 6, 7, 0},
        };

        int[] shortestPath = Dijkstra(graph, 0);

        Console.WriteLine("Shortest paths from node 0:");
        for (int i = 0; i < shortestPath.Length; i++)
        {
            Console.WriteLine($"Node {i}: {shortestPath[i]}");
        }

    }
}
