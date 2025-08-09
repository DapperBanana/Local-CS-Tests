
using System;

class Stack
{
    private int[] data;
    private int top;

    public Stack(int size)
    {
        data = new int[size];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == data.Length - 1)
        {
            Console.WriteLine("Stack overflow");
            return;
        }

        data[++top] = value;
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack underflow");
            return -1;
        }

        return data[top--];
    }
}

class Program
{
    static void Main()
    {
        Stack stack = new Stack(5);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Popped element: " + stack.Pop());
    }
}
