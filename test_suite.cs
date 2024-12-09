
using System;

public class Stack
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
            Console.WriteLine("Stack is full. Cannot push element.");
            return;
        }
        
        stackArray[++top] = value;
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty. Cannot pop element.");
            return -1;
        }

        return stackArray[top--];
    }

    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty. Cannot peek element.");
            return -1;
        }

        return stackArray[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == maxSize - 1;
    }

    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty.");
        }
        else
        {
            Console.Write("Stack: ");
            for (int i = 0; i <= top; i++)
            {
                Console.Write(stackArray[i] + " ");
            }
            Console.WriteLine();
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
        stack.Display();

        Console.WriteLine("Popped element: " + stack.Pop());
        stack.Display();

        Console.WriteLine("Peeked element: " + stack.Peek());
        
        Console.WriteLine("Is stack empty: " + stack.IsEmpty());
        Console.WriteLine("Is stack full: " + stack.IsFull());
    }
}
