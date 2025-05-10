
using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<Tuple<int, int>>[] adj;

    public Graph(int vertices)
    {
        V = vertices;
        adj = new List<Tuple<int, int>>[V];

        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<Tuple<int, int>>();
        }
    }

    public void AddEdge(int u, int v, int weight)
    {
        adj[u].Add(new Tuple<int, int>(v, weight));
        adj[v].Add(new Tuple<int, int>(u, weight));
    }

    public void Dijkstra(int source)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
        }

        dist[source] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, visited);
            visited[u] = true;

            foreach (var edge in adj[u])
            {
                int v = edge.Item1;
                int weight = edge.Item2;

                if (!visited[v] && dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                {
                    dist[v] = dist[u] + weight;
                }
            }
        }

        PrintSolution(dist);
    }

    private int MinDistance(int[] dist, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    private void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vertex Distance from Source");

        for (int i = 0; i < V; i++)
        {
            Console.WriteLine("{0}\t\t{1}", i, dist[i]);
        }
    }

    public static void Main()
    {
        Graph g = new Graph(9);
        g.AddEdge(0, 1, 4);
        g.AddEdge(0, 7, 8);
        g.AddEdge(1, 2, 8);
        g.AddEdge(1, 7, 11);
        g.AddEdge(2, 3, 7);
        g.AddEdge(2, 8, 2);
        g.AddEdge(2, 5, 4);
        g.AddEdge(3, 4, 9);
        g.AddEdge(3, 5, 14);
        g.AddEdge(4, 5, 10);
        g.AddEdge(5, 6, 2);
        g.AddEdge(6, 7, 1);
        g.AddEdge(6, 8, 6);
        g.AddEdge(7, 8, 7);

        g.Dijkstra(0);
    }
}
