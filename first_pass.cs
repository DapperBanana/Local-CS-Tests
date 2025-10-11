
using System;
using System.Collections;

public class SimpleQueue
{
    private Queue queue = new Queue();

    public void Enqueue(object obj)
    {
        queue.Enqueue(obj);
    }

    public object Dequeue()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return queue.Dequeue();
    }

    public object Peek()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return queue.Peek();
    }

    public int Count()
    {
        return queue.Count;
    }

    public void PrintQueue()
    {
        foreach (object obj in queue)
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
        SimpleQueue queue = new SimpleQueue();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        queue.PrintQueue();

        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine("Peek: " + queue.Peek());

        queue.PrintQueue();
    }
}
