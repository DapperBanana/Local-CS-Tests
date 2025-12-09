using System;
using System.Collections.Generic;

class Graph
{
    private int vertices;
    private List<(int, int)>[] adj;

    public Graph(int v)
    {
        vertices = v;
        adj = new List<(int, int)>[v];
        for (int i = 0; i < v; i++)
            adj[i] = new List<(int, int)>();
    }

    public void AddEdge(int u, int v, int weight)
    {
        adj[u].Add((v, weight));
        // For undirected graph, add the reverse edge:
        // adj[v].Add((u, weight));
    }

    public int[] Dijkstra(int start)
    {
        int[] dist = new int[vertices];
        bool[] visited = new bool[vertices];

        for (int i = 0; i < vertices; i++)
            dist[i] = int.MaxValue;

        dist[start] = 0;

        var priorityQueue = new SortedSet<(int dist, int node)>(Comparer<(int, int)>.Create((a, b) =>
        {
            int result = a.dist.CompareTo(b.dist);
            if (result == 0)
                result = a.node.CompareTo(b.node);
            return result;
        }));

        priorityQueue.Add((0, start));

        while (priorityQueue.Count > 0)
        {
            var (currentDist, u) = GetAndRemoveFirst(priorityQueue);

            if (visited[u])
                continue;

            visited[u] = true;

            foreach (var (v, weight) in adj[u])
            {
                if (!visited[v] && dist[u] + weight < dist[v])
                {
                    dist[v] = dist[u] + weight;
                    priorityQueue.Add((dist[v], v));
                }
            }
        }

        return dist;
    }

    private static (int, int) GetAndRemoveFirst(SortedSet<(int, int)> set)
    {
        var first = set.Min;
        set.Remove(first);
        return first;
    }

    // Optional: Method to reconstruct the shortest path
    public List<int> GetShortestPath(int start, int end)
    {
        int[] dist = new int[vertices];
        int[] prev = new int[vertices];
        for (int i = 0; i < vertices; i++)
        {
            dist[i] = int.MaxValue;
            prev[i] = -1;
        }
        dist[start] = 0;

        var priorityQueue = new SortedSet<(int dist, int node)>(Comparer<(int, int)>.Create((a, b) =>
        {
            int result = a.dist.CompareTo(b.dist);
            if (result == 0)
                result = a.node.CompareTo(b.node);
            return result;
        }));

        priorityQueue.Add((0, start));

        while (priorityQueue.Count > 0)
        {
            var (currentDist, u) = GetAndRemoveFirst(priorityQueue);

            if (u == end)
                break;

            foreach (var (v, weight) in adj[u])
            {
                if (dist[u] + weight < dist[v])
                {
                    dist[v] = dist[u] + weight;
                    prev[v] = u;
                    priorityQueue.Add((dist[v], v));
                }
            }
        }

        var path = new List<int>();
        for (int at = end; at != -1; at = prev[at])
            path.Add(at);
        path.Reverse();

        if (path[0] == start)
            return path;
        else
            return new List<int>(); // No path found
    }
}

class Program
{
    static void Main()
    {
        var g = new Graph(6);

        g.AddEdge(0, 1, 7);
        g.AddEdge(0, 2, 9);
        g.AddEdge(0, 5, 14);
        g.AddEdge(1, 2, 10);
        g.AddEdge(1, 3, 15);
        g.AddEdge(2, 3, 11);
        g.AddEdge(2, 5, 2);
        g.AddEdge(3, 4, 6);
        g.AddEdge(4, 5, 9);

        int start = 0;
        int[] distances = g.Dijkstra(start);

        Console.WriteLine("Vertex\tDistance from Source");
        for (int i = 0; i < distances.Length; i++)
        {
            Console.WriteLine($"{i}\t{distances[i]}");
        }

        // Optional: get shortest path from start to a target
        int target = 4;
        var path = g.GetShortestPath(start, target);
        Console.WriteLine($"Shortest path from {start} to {target}: {string.Join(" -> ", path)}");
    }
}