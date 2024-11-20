
using System;
using System.Collections.Generic;

class Graph
{
    private int V; 
    private List<int>[] adjList;

    public Graph(int vertices)
    {
        V = vertices;
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
        bool[] visited = new bool[V];
        int[] prev = new int[V];

        for (int i = 0; i < V; i++)
        {
            visited[i] = false;
            prev[i] = -1;
        }

        queue.Enqueue(start);
        visited[start] = true;

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            if (current == end)
            {
                break;
            }

            foreach (var neighbor in adjList[current])
            {
                if (!visited[neighbor])
                {
                    queue.Enqueue(neighbor);
                    visited[neighbor] = true;
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
        Graph graph = new Graph(6);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(1, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(1, 4);
        graph.AddEdge(4, 5);

        List<int> shortestPath = graph.ShortestPath(0, 5);

        Console.WriteLine("Shortest Path from 0 to 5:");
        foreach (int vertex in shortestPath)
        {
            Console.Write(vertex + " ");
        }
    }
}
