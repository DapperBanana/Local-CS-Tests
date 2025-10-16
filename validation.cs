
using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<int>[] adj;

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    public List<int> ShortestPath(int start, int end)
    {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[V];
        int[] parent = new int[V];

        queue.Enqueue(start);
        visited[start] = true;

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            if (current == end)
            {
                List<int> path = new List<int>();
                for (int i = end; i != start; i = parent[i])
                {
                    path.Add(i);
                }
                path.Add(start);
                path.Reverse();
                return path;
            }

            foreach (int neighbor in adj[current])
            {
                if (!visited[neighbor])
                {
                    queue.Enqueue(neighbor);
                    visited[neighbor] = true;
                    parent[neighbor] = current;
                }
            }
        }

        return new List<int>();
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(6);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 4);
        g.AddEdge(3, 5);
        g.AddEdge(4, 5);

        List<int> path = g.ShortestPath(0, 5);

        if (path.Count > 0)
        {
            Console.WriteLine("Shortest path from 0 to 5:");
            foreach (var vertex in path)
            {
                Console.Write(vertex + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There is no path from 0 to 5.");
        }
    }
}
