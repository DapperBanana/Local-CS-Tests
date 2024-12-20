
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

    public void ShortestPath(int start, int end)
    {
        bool[] visited = new bool[V];
        int[] dist = new int[V];
        int[] prev = new int[V];
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < V; i++)
        {
            visited[i] = false;
            dist[i] = int.MaxValue;
            prev[i] = -1;
        }

        visited[start] = true;
        dist[start] = 0;
        queue.Enqueue(start);

        while (queue.Count != 0)
        {
            int current = queue.Dequeue();

            foreach (int next in adj[current])
            {
                if (!visited[next])
                {
                    visited[next] = true;
                    dist[next] = dist[current] + 1;
                    prev[next] = current;
                    queue.Enqueue(next);
                }
            }
        }

        // Backtrack to reconstruct the shortest path
        if (dist[end] != int.MaxValue)
        {
            Console.Write("Shortest path from " + start + " to " + end + " is: ");
            int current = end;
            while (current != -1)
            {
                Console.Write(current + " ");
                current = prev[current];
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No path from " + start + " to " + end);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph g = new Graph(6);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(1, 3);
        g.AddEdge(2, 3);
        g.AddEdge(3, 4);
        g.AddEdge(4, 5);

        g.ShortestPath(0, 5);
    }
}
