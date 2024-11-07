
using System;

public class Queue
{
    private int[] elements;
    private int front;
    private int rear;
    private int size;

    public Queue(int capacity)
    {
        elements = new int[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void Enqueue(int element)
    {
        if (size == elements.Length)
        {
            Console.WriteLine("Queue is full, cannot enqueue element");
            return;
        }

        rear = (rear + 1) % elements.Length;
        elements[rear] = element;
        size++;
    }

    public int Dequeue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty, cannot dequeue element");
            return -1;
        }

        int dequeuedElement = elements[front];
        front = (front + 1) % elements.Length;
        size--;

        return dequeuedElement;
    }

    public bool IsEmpty()
    {
        return size == 0;
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

        while (!queue.IsEmpty())
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
