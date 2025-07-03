
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adjacencyList;

    public Graph(int vertices)
    {
        V = vertices;
        adjacencyList = new List<int>[vertices];
        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adjacencyList[v].Add(w);
    }

    public void BFS(int start, int end)
    {
        bool[] visited = new bool[V];
        int[] parent = new int[V];
        for (int i = 0; i < V; i++)
        {
            parent[i] = -1;
        }

        Queue<int> queue = new Queue<int>();
        visited[start] = true;
        queue.Enqueue(start);

        while (queue.Count != 0)
        {
            int current = queue.Dequeue();

            if (current == end)
            {
                Console.WriteLine("Shortest path is: ");
                PrintPath(parent, current);
                return;
            }

            foreach (int neighbor in adjacencyList[current])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    parent[neighbor] = current;
                    queue.Enqueue(neighbor);
                }
            }
        }

        Console.WriteLine("There is no path between the two vertices.");
    }

    private void PrintPath(int[] parent, int current)
    {
        if (current == -1)
        {
            return;
        }
        PrintPath(parent, parent[current]);
        Console.Write(current + " ");
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);

        int startVertex = 0;
        int endVertex = 4;

        graph.BFS(startVertex, endVertex);
    }
}
