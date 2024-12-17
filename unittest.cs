
using System;
using System.Collections.Generic;

class QueueExample
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        // Enqueue elements
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // Display elements in the queue
        Console.WriteLine("Elements in the queue:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        // Dequeue an element
        int element = queue.Dequeue();
        Console.WriteLine($"Dequeued element: {element}");

        // Display elements in the queue after dequeue
        Console.WriteLine("\nElements in the queue after dequeue:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
