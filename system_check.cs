
using System;

public class Stack
{
    private int[] data;
    private int top;

    public Stack(int capacity)
    {
        data = new int[capacity];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == data.Length - 1)
        {
            Console.WriteLine("Stack overflow");
        }
        else
        {
            top++;
            data[top] = value;
        }
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack underflow");
            return -1;
        }
        else
        {
            int value = data[top];
            top--;
            return value;
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

public class Program
{
    public static void Main()
    {
        Stack stack = new Stack(5);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        stack.PrintStack();

        Console.WriteLine("Popped value: " + stack.Pop());

        stack.PrintStack();
    }
}
