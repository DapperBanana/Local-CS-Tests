
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
        array = new int[size];
        front = 0;
        rear = -1;
        this.size = 0;
    }

    public void Enqueue(int item)
    {
        if (size == capacity)
        {
            Console.WriteLine("Queue is full");
            return;
        }

        rear = (rear + 1) % capacity;
        array[rear] = item;
        size++;
        Console.WriteLine("Enqueued: " + item);
    }

    public int Dequeue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty");
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
            Console.WriteLine("Queue is empty");
            return -1;
        }

        return array[front];
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

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        queue.PrintQueue();

        Console.WriteLine("Dequeued: " + queue.Dequeue());

        queue.PrintQueue();

        Console.WriteLine("Peek: " + queue.Peek());

        queue.Enqueue(5);
        queue.Enqueue(6);

        queue.PrintQueue();

        queue.Enqueue(7);

        queue.PrintQueue();
    }
}
