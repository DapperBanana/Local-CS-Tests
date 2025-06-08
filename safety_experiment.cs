
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> myQueue = new Queue<int>();

        myQueue.Enqueue(10);
        myQueue.Enqueue(20);
        myQueue.Enqueue(30);

        Console.WriteLine("Elements in the queue:");
        foreach (int item in myQueue)
        {
            Console.WriteLine(item);
        }

        int dequeuedItem = myQueue.Dequeue();
        Console.WriteLine($"\nDequeued item: {dequeuedItem}");

        Console.WriteLine("\nElements in the queue after dequeue:");
        foreach (int item in myQueue)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}
