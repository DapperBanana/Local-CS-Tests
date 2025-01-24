
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
        bool[] visited = new bool[V];
        int[] distance = new int[V];

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;
        distance[start] = 0;

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();

            foreach (int neighbor in adj[node])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    distance[neighbor] = distance[node] + 1;
                    queue.Enqueue(neighbor);
                }
            }
        }

        List<int> path = new List<int>();
        int current = end;
        while (current != start)
        {
            path.Add(current);
            foreach (int neighbor in adj[current])
            {
                if (distance[neighbor] == distance[current] - 1)
                {
                    current = neighbor;
                    break;
                }
            }
        }
        path.Add(start);
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
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 5);
        graph.AddEdge(4, 5);

        List<int> path = graph.ShortestPath(0, 5);

        Console.WriteLine("Shortest Path from node 0 to node 5:");
        foreach (int node in path)
        {
            Console.Write(node + " ");
        }
        Console.WriteLine();
    }
}
