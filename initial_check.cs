
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        // Enqueue elements to the queue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);

        // Print queue elements
        Console.WriteLine("Queue elements:");
        foreach (int i in queue)
        {
            Console.WriteLine(i);
        }

        // Dequeue elements from the queue
        int item = queue.Dequeue();
        Console.WriteLine($"Dequeued item: {item}");

        // Print updated queue elements
        Console.WriteLine("\nUpdated queue elements:");
        foreach (int i in queue)
        {
            Console.WriteLine(i);
        }
    }
}
