
using System;
using System.Collections.Generic;

class DijkstraAlgorithm
{
    private static int V = 9;

    private int MinDistance(int[] dist, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < V; i++)
        {
            if (!visited[i] && dist[i] <= min)
            {
                min = dist[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    private void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vertex \t Distance from Source");
        for (int i = 0; i < V; i++)
        {
            Console.WriteLine(i + " \t " + dist[i]);
        }
    }

    public void Dijkstra(int[,] graph, int src)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, visited);
            visited[u] = true;

            for (int v = 0; v < V; v++)
            {
                if (!visited[v] && graph[u, v] != 0 && dist[u] != int.MaxValue &&
                   dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                }
            }
        }

        PrintSolution(dist);
    }

    public static void Main()
    {
        int[,] graph = new int[,] {
            { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
            { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
            { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
            { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
            { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
        };

        DijkstraAlgorithm dijkstra = new DijkstraAlgorithm();
        dijkstra.Dijkstra(graph, 0);
    }
}
