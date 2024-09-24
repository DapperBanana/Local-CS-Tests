
using System;
using System.Collections.Generic;

class Queue<T>
{
    private List<T> items = new List<T>();

    public void Enqueue(T item)
    {
        items.Add(item);
    }

    public T Dequeue()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T item = items[0];
        items.RemoveAt(0);
        return item;
    }

    public int Count
    {
        get { return items.Count; }
    }

    public bool IsEmpty
    {
        get { return items.Count == 0; }
    }
}

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine($"Queue count: {queue.Count}");

        while (!queue.IsEmpty)
        {
            int item = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {item}");
        }

        Console.WriteLine($"Queue count after dequeue: {queue.Count}");
    }
}
