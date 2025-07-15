
using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<List<int>> adjList;

    public Graph(int v)
    {
        V = v;
        adjList = new List<List<int>>();
        for (int i = 0; i < v; i++)
        {
            adjList.Add(new List<int>());
        }
    }

    public void AddEdge(int u, int v)
    {
        adjList[u].Add(v);
        adjList[v].Add(u);
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
            {
                return true;
            }
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

class MainClass
{
    public static void Main(string[] args)
    {
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);

        if (graph.IsTree())
            Console.WriteLine("The given graph is a tree.");
        else
            Console.WriteLine("The given graph is not a tree.");
    }
}
