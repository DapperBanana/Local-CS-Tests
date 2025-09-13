
using System;
using System.Collections.Generic;

public class QueueProgram
{
    static void Main()
    {
        Queue<int> myQueue = new Queue<int>();

        // Enqueue elements into the queue
        myQueue.Enqueue(10);
        myQueue.Enqueue(20);
        myQueue.Enqueue(30);
        myQueue.Enqueue(40);
        myQueue.Enqueue(50);

        // Dequeue elements from the queue
        Console.WriteLine("Dequeued Element: {0}", myQueue.Dequeue());
        Console.WriteLine("Dequeued Element: {0}", myQueue.Dequeue());

        // Peek at the first element in the queue
        Console.WriteLine("Peeked Element: {0}", myQueue.Peek());

        // Print all elements in the queue
        Console.WriteLine("Elements in the queue:");
        foreach (int item in myQueue)
        {
            Console.WriteLine(item);
        }
    }
}
