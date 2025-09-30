
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
        myQueue.Enqueue(40);

        // Dequeue element
        Console.WriteLine("Dequeued element: {0}", myQueue.Dequeue());

        // Peek element
        Console.WriteLine("Peeked element: {0}", myQueue.Peek());

        // Print elements
        Console.WriteLine("Elements in queue:");
        foreach (int num in myQueue)
        {
            Console.WriteLine(num);
        }
    }
}
