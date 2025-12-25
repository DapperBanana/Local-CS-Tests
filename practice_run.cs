using System;
using System.Collections.Generic;

class Graph
{
    private int vertices;
    private List<(int, int)>[] adjacencyList;

    public Graph(int vertices)
    {
        this.vertices = vertices;
        adjacencyList = new List<(int, int)>[vertices];
        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<(int, int)>();
        }
    }

    public void AddEdge(int src, int dest, int weight)
    {
        adjacencyList[src].Add((dest, weight));
        // If undirected graph, uncomment the next line
        // adjacencyList[dest].Add((src, weight));
    }

    public int[] Dijkstra(int start)
    {
        int[] distances = new int[vertices];
        bool[] visited = new bool[vertices];

        for (int i = 0; i < vertices; i++)
            distances[i] = int.MaxValue;

        distances[start] = 0;

        var priorityQueue = new SortedSet<(int distance, int node)>(Comparer<(int, int)>.Create((a, b) =>
        {
            int cmp = a.distance.CompareTo(b.distance);
            if (cmp == 0)
                return a.node.CompareTo(b.node);
            return cmp;
        }));

        priorityQueue.Add((0, start));

        while (priorityQueue.Count > 0)
        {
            var current = priorityQueue.Min;
            priorityQueue.Remove(current);

            int currentNode = current.node;
            if (visited[currentNode])
                continue;

            visited[currentNode] = true;

            foreach (var (neighbor, weight) in adjacencyList[currentNode])
            {
                if (!visited[neighbor] && distances[currentNode] + weight < distances[neighbor])
                {
                    distances[neighbor] = distances[currentNode] + weight;
                    priorityQueue.Add((distances[neighbor], neighbor));
                }
            }
        }

        return distances;
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(6);
        graph.AddEdge(0, 1, 7);
        graph.AddEdge(0, 2, 9);
        graph.AddEdge(0, 5, 14);
        graph.AddEdge(1, 2, 10);
        graph.AddEdge(1, 3, 15);
        graph.AddEdge(2, 3, 11);
        graph.AddEdge(2, 5, 2);
        graph.AddEdge(3, 4, 6);
        graph.AddEdge(4, 5, 9);

        int startNode = 0;
        int[] shortestDistances = graph.Dijkstra(startNode);

        Console.WriteLine($"Shortest distances from node {startNode}:");
        for (int i = 0; i < shortestDistances.Length; i++)
        {
            Console.WriteLine($"Node {i} : {shortestDistances[i]}");
        }
    }
}