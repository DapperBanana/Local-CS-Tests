
using System;

public class Stack
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

    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }

        return data[top];
    }

    public void PrintStack()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        Console.Write("Stack: ");
        for (int i = 0; i <= top; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        Stack stack = new Stack(5);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.PrintStack();

        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Top element: " + stack.Peek());
        stack.PrintStack();

        stack.Push(4);
        stack.Push(5);
        stack.Push(6); // Will print stack overflow
        stack.PrintStack();
    }
}
