
using System;
using System.Collections.Generic;

class QueueProgram
{
    static void Main()
    {
        Queue<int> myQueue = new Queue<int>();

        // Enqueue elements
        myQueue.Enqueue(10);
        myQueue.Enqueue(20);
        myQueue.Enqueue(30);

        // Print queue elements
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }

        // Dequeue elements
        int dequeuedItem = myQueue.Dequeue();
        Console.WriteLine($"Dequeued: {dequeuedItem}");

        // Print queue elements after dequeue
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }

        // Peek at the front element
        int frontItem = myQueue.Peek();
        Console.WriteLine($"Front item: {frontItem}");
    }
}
