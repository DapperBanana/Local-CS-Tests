
using System;

class Stack
{
    private int maxSize;
    private int[] stackArray;
    private int top;

    public Stack(int size)
    {
        maxSize = size;
        stackArray = new int[maxSize];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == maxSize - 1)
        {
            Console.WriteLine("Stack is full, cannot push element");
        }
        else
        {
            stackArray[++top] = value;
            Console.WriteLine(value + " pushed to stack");
        }
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty, cannot pop element");
            return -1;
        }
        else
        {
            int value = stackArray[top--];
            return value;
        }
    }
}

class Program
{
    static void Main()
    {
        Stack stack = new Stack(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Popped element: " + stack.Pop());
    }
}
