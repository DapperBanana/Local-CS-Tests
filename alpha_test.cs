
using System;
using System.Collections;

public class Queue
{
    private ArrayList _queue;

    public Queue()
    {
        _queue = new ArrayList();
    }

    public void Enqueue(object obj)
    {
        _queue.Add(obj);
    }

    public object Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        object obj = _queue[0];
        _queue.RemoveAt(0);
        return obj;
    }

    public object Peek()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return _queue[0];
    }

    public int Count
    {
        get { return _queue.Count; }
    }

    public void Print()
    {
        foreach (var obj in _queue)
        {
            Console.Write(obj + " ");
        }
        
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Queue queue = new Queue();

        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");

        Console.WriteLine("Queue elements:");
        queue.Print();

        Console.WriteLine("Front element: " + queue.Peek());

        Console.WriteLine("Dequeue: " + queue.Dequeue());

        Console.WriteLine("Queue elements after dequeue:");
        queue.Print();

        Console.WriteLine("Number of elements in the queue: " + queue.Count);
    }
}
