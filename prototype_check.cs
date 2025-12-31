using System;

public class Stack<T>
{
    private T[] elements;
    private int size;
    private int capacity;

    public Stack(int initialCapacity = 10)
    {
        capacity = initialCapacity;
        elements = new T[capacity];
        size = 0;
    }

    public void Push(T item)
    {
        if (size == capacity)
        {
            Resize();
        }
        elements[size++] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");

        T item = elements[--size];
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");

        return elements[size - 1];
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    private void Resize()
    {
        capacity *= 2;
        T[] newElements = new T[capacity];
        Array.Copy(elements, newElements, size);
        elements = newElements;
    }
}

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        Console.WriteLine(stack.Peek()); // Output: 20
        Console.WriteLine(stack.Pop());  // Output: 20
        Console.WriteLine(stack.Peek()); // Output: 10
        Console.WriteLine(stack.IsEmpty()); // Output: False
        stack.Pop();
        Console.WriteLine(stack.IsEmpty()); // Output: True
    }
}