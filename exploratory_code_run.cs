using System;

public class SimpleStack<T>
{
    private T[] items;
    private int top;
    private int capacity;

    public SimpleStack(int size)
    {
        capacity = size;
        items = new T[capacity];
        top = -1;
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == capacity - 1;
    }

    public void Push(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full. Cannot push new item.");
            return;
        }
        items[++top] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot pop item.");
            return default(T);
        }
        return items[top--];
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return default(T);
        }
        return items[top];
    }
}

// Example usage:
public class Program
{
    public static void Main()
    {
        SimpleStack<int> stack = new SimpleStack<int>(5);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Top item: " + stack.Peek());

        Console.WriteLine("Pop item: " + stack.Pop());
        Console.WriteLine("Pop item: " + stack.Pop());
        Console.WriteLine("Pop item: " + stack.Pop());

        Console.WriteLine("Is stack empty? " + stack.IsEmpty());
    }
}