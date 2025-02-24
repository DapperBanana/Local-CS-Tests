
using System;
using System.Collections.Generic;

public class ShortestPathDijkstra
{
    private int V;
    private List<(int, int)>[] adjList;

    public ShortestPathDijkstra(int vertices)
    {
        V = vertices;
        adjList = new List<(int, int)>[V];
        for (int i = 0; i < V; i++)
        {
            adjList[i] = new List<(int, int)>();
        }
    }

    public void AddEdge(int u, int v, int weight)
    {
        adjList[u].Add((v, weight));
        adjList[v].Add((u, weight));
    }

    public void Dijkstra(int source)
    {
        int[] dist = new int[V];
        Array.Fill(dist, int.MaxValue);
        dist[source] = 0;

        SortedSet<(int, int)> pq = new SortedSet<(int, int)>();
        pq.Add((0, source));

        while (pq.Count > 0)
        {
            int u = pq.Min.Item2;
            pq.Remove(pq.Min);

            foreach (var edge in adjList[u])
            {
                int v = edge.Item1;
                int weight = edge.Item2;

                if (dist[u] + weight < dist[v])
                {
                    pq.Remove((dist[v], v));
                    dist[v] = dist[u] + weight;
                    pq.Add((dist[v], v));
                }
            }
        }

        for (int i = 0; i < V; i++)
        {
            Console.WriteLine($"Shortest distance from {source} to {i} is {dist[i]}");
        }
    }

    public static void Main()
    {
        ShortestPathDijkstra graph = new ShortestPathDijkstra(6);
        graph.AddEdge(0, 1, 4);
        graph.AddEdge(0, 2, 3);
        graph.AddEdge(1, 2, 1);
        graph.AddEdge(1, 3, 2);
        graph.AddEdge(2, 3, 4);
        graph.AddEdge(3, 4, 2);
        graph.AddEdge(4, 5, 6);

        graph.Dijkstra(0);
    }
}
