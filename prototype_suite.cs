
using System;

public class Queue
{
    private int[] array;
    private int front;
    private int rear;
    private int capacity;
    private int size;

    public Queue(int size)
    {
        this.capacity = size;
        this.array = new int[size];
        this.front = 0;
        this.rear = -1;
        this.size = 0;
    }

    public void Enqueue(int item)
    {
        if (size == capacity)
        {
            Console.WriteLine("Queue is full. Enqueue operation failed.");
            return;
        }

        rear = (rear + 1) % capacity;
        array[rear] = item;
        size++;
        Console.WriteLine($"{item} enqueued to queue");
    }

    public int Dequeue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty. Dequeue operation failed.");
            return -1;
        }

        int item = array[front];
        front = (front + 1) % capacity;
        size--;
        return item;
    }

    public int Peek()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty. Peek operation failed.");
            return -1;
        }

        return array[front];
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public void PrintQueue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }
        
        Console.Write("Queue: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[(front + i) % capacity] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Queue queue = new Queue(5);

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue.PrintQueue();

        Console.WriteLine("Dequeued item: " + queue.Dequeue());
        Console.WriteLine("Peeked item: " + queue.Peek());

        queue.PrintQueue();
    }
}
