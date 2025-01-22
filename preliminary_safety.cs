
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public List<int> ShortestPath(int start, int end)
    {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[V];
        int[] parent = new int[V];

        queue.Enqueue(start);
        visited[start] = true;
        parent[start] = -1;

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            if (current == end)
            {
                break;
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

        List<int> path = new List<int>();
        int at = end;
        while (at != -1)
        {
            path.Add(at);
            at = parent[at];
        }

        path.Reverse();
        return path;
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(6);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(2, 4);

        List<int> path = graph.ShortestPath(0, 4);

        Console.WriteLine("Shortest path from 0 to 4:");
        foreach (int vertex in path)
        {
            Console.Write(vertex + " ");
        }
    }
}
