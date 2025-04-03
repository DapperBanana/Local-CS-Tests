
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adjList; // Adjacency list

    public Graph(int vertices)
    {
        V = vertices;
        adjList = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adjList[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adjList[v].Add(w);
        adjList[w].Add(v);
    }

    private bool IsCyclicUtil(int v, bool[] visited, int parent)
    {
        visited[v] = true;

        foreach (int i in adjList[v])
        {
            if (!visited[i])
            {
                if (IsCyclicUtil(i, visited, v))
                    return true;
            }
            else if (i != parent)
                return true;
        }
        return false;
    }

    public bool IsTree()
    {
        bool[] visited = new bool[V];
        if (IsCyclicUtil(0, visited, -1))
            return false;

        for (int i = 0; i < V; i++)
        {
            if (!visited[i])
                return false;
        }

        return true;
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
        graph.AddEdge(3, 4);

        if (graph.IsTree())
            Console.WriteLine("The graph is a tree.");
        else
            Console.WriteLine("The graph is not a tree.");
    }
}
