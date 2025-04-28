
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

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void BFS(int s, int d)
    {
        bool[] visited = new bool[V];
        int[] parent = new int[V];
        Queue<int> queue = new Queue<int>();

        visited[s] = true;
        queue.Enqueue(s);

        while (queue.Count != 0)
        {
            int current = queue.Dequeue();
            if (current == d)
            {
                List<int> path = new List<int>();
                int i = d;
                while (i != s)
                {
                    path.Add(i);
                    i = parent[i];
                }
                path.Add(s);
                path.Reverse();

                Console.Write("Shortest path from " + s + " to " + d + ": ");
                foreach (int vertex in path)
                {
                    Console.Write(vertex + " ");
                }
                Console.WriteLine();
                return;
            }

            foreach (int neighbor in adj[current])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    parent[neighbor] = current;
                    queue.Enqueue(neighbor);
                }
            }
        }

        Console.WriteLine("No path found from " + s + " to " + d);
    }

    public static void Main()
    {
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 4);

        graph.BFS(0, 4);
    }
}
