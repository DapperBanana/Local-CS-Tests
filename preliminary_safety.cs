
using System;

class Stack
{
    private int[] data;
    private int top;

    public Stack(int maxSize)
    {
        data = new int[maxSize];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == data.Length - 1)
        {
            Console.WriteLine("Stack is full");
        }
        else
        {
            data[++top] = value;
        }
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            return data[top--];
        }
    }

    public void PrintStack()
    {
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(data[i]);
        }
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
        stack.Push(4);

        stack.PrintStack();

        stack.Pop();

        stack.PrintStack();
    }
}
