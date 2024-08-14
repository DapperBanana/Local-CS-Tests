
using System;

public class Stack
{
    private int top;
    private int[] data;
    private int maxSize;

    public Stack(int size)
    {
        top = -1;
        maxSize = size;
        data = new int[size];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == maxSize - 1;
    }

    public void Push(int value)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack overflow");
            return;
        }
        top++;
        data[top] = value;
        Console.WriteLine(value + " pushed to stack");
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack underflow");
            return -1;
        }
        int value = data[top];
        top--;
        return value;
    }

    public void PrintStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        Console.WriteLine("Stack elements:");
        for (int i = 0; i <= top; i++)
        {
            Console.WriteLine(data[i]);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Stack stack = new Stack(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        stack.PrintStack();

        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Popped element: " + stack.Pop());

        stack.PrintStack();
    }
}
