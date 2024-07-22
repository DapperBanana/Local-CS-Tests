
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
            Console.WriteLine("Stack is full. Cannot push element.");
        }
        else
        {
            top++;
            data[top] = value;
            Console.WriteLine("Pushed element: " + value);
        }
    }

    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty. Cannot pop element.");
        }
        else
        {
            int poppedElement = data[top];
            top--;
            Console.WriteLine("Popped element: " + poppedElement);
        }
    }

    public void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty. Cannot peek element.");
        }
        else
        {
            Console.WriteLine("Top element: " + data[top]);
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
        stack.Pop();
        stack.Push(4);
        stack.Push(5);
        stack.Peek();
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();
    }
}
