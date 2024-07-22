
using System;

public class Stack
{
    private object[] data;
    private int top;

    public Stack(int size)
    {
        data = new object[size];
        top = -1;
    }

    public void Push(object value)
    {
        if (top == data.Length - 1)
        {
            Console.WriteLine("Stack is full, cannot push element.");
            return;
        }

        top++;
        data[top] = value;
    }

    public object Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty, cannot pop element.");
            return null;
        }

        object value = data[top];
        top--;
        return value;
    }

    public object Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty, cannot peek element.");
            return null;
        }

        return data[top];
    }

    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.Write("Stack elements: ");
        for (int i = top; i >= 0; i--)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Stack stack = new Stack(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Display();

        Console.WriteLine("Peek: " + stack.Peek());

        stack.Pop();
        stack.Display();

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Display();
    }
}
