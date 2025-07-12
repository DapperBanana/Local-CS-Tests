
using System;

public class Queue
{
    private int[] items;
    private int front;
    private int rear;
    private int size;

    public Queue(int capacity)
    {
        items = new int[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void Enqueue(int item)
    {
        if (size == items.Length)
        {
            Console.WriteLine("Queue is full");
            return;
        }

        rear = (rear + 1) % items.Length;
        items[rear] = item;
        size++;
    }

    public int Dequeue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        int item = items[front];
        front = (front + 1) % items.Length;
        size--;

        return item;
    }

    public void PrintQueue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        for (int i = 0; i < size; i++)
        {
            int index = (front + i) % items.Length;
            Console.Write(items[index] + " ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        Queue queue = new Queue(5);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        queue.PrintQueue();

        Console.WriteLine("Dequeued item: " + queue.Dequeue());
        Console.WriteLine("Dequeued item: " + queue.Dequeue());

        queue.PrintQueue();
    }
}
