
using System;
using System.Collections.Generic;

class Graph
{
    private int vertices;
    private List<List<int>> adjList;

    public Graph(int vertices)
    {
        this.vertices = vertices;
        adjList = new List<List<int>>(vertices);

        for (int i = 0; i < vertices; i++)
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
                {
                    return true;
                }
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
        bool[] visited = new bool[vertices];

        if (IsCyclicUtil(0, visited, -1))
        {
            return false;
        }

        for (int i = 0; i < vertices; i++)
        {
            if (!visited[i])
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(5);
        g.AddEdge(0, 1);
        g.AddEdge(1, 2);
        g.AddEdge(2, 3);
        g.AddEdge(3, 4);

        if (g.IsTree())
        {
            Console.WriteLine("The graph is a tree.");
        }
        else
        {
            Console.WriteLine("The graph is not a tree.");
        }
    }
}
