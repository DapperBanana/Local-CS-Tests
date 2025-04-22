
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

        Console.WriteLine("Queue elements:");
        foreach (int item in myQueue)
        {
            Console.WriteLine(item);
        }

        int removedItem = myQueue.Dequeue();
        Console.WriteLine($"Removed item: {removedItem}");

        Console.WriteLine("Updated queue elements:");
        foreach (int item in myQueue)
        {
            Console.WriteLine(item);
        }
    }
}
