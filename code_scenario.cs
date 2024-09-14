
using System;

public class Stack
{
    private int[] stackArray;
    private int top;
    private int maxSize;

    public Stack(int size)
    {
        maxSize = size;
        stackArray = new int[maxSize];
        top = -1;
    }

    public void Push(int value)
    {
        if (top < maxSize - 1)
        {
            stackArray[++top] = value;
            Console.WriteLine("Pushed element: " + value);
        }
        else
        {
            Console.WriteLine("Stack is full, cannot push element.");
        }
    }

    public void Pop()
    {
        if (top >= 0)
        {
            int poppedValue = stackArray[top--];
            Console.WriteLine("Popped element: " + poppedValue);
        }
        else
        {
            Console.WriteLine("Stack is empty, cannot pop element.");
        }
    }

    public void Peek()
    {
        if (top >= 0)
        {
            Console.WriteLine("Top element: " + stackArray[top]);
        }
        else
        {
            Console.WriteLine("Stack is empty.");
        }
    }
}

class Program
{
    public static void Main()
    {
        Stack stack = new Stack(5);

        stack.Push(5);
        stack.Push(10);
        stack.Push(15);
        stack.Peek();
        stack.Pop();
        stack.Peek();
        stack.Pop();
        stack.Pop();
        stack.Peek();
    }
}
