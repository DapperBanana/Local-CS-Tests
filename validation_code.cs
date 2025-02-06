
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // number of vertices
    private List<int>[] adjList; // adjacency list representation of graph

    public Graph(int v)
    {
        V = v;
        adjList = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adjList[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        adjList[u].Add(v);
    }

    public List<int> ShortestPath(int start, int end)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);

        bool[] visited = new bool[V];
        int[] prev = new int[V];

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            if (current == end)
            {
                break;
            }

            foreach (int neighbor in adjList[current])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                    prev[neighbor] = current;
                }
            }
        }

        List<int> path = new List<int>();
        for (int at = end; at != -1; at = prev[at])
        {
            path.Add(at);
        }
        path.Reverse();

        return path;
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
        g.AddEdge(2, 3);
        g.AddEdge(3, 4);
        g.AddEdge(4, 5);

        List<int> shortestPath = g.ShortestPath(0, 5);

        Console.WriteLine("Shortest path from 0 to 5: ");
        foreach (int vertex in shortestPath)
        {
            Console.Write(vertex + " ");
        }
    }
}
