
using System;

class Stack
{
    private int[] stackArray;
    private int top;
    private int maxSize;

    public Stack(int size)
    {
        stackArray = new int[size];
        top = -1;
        maxSize = size;
    }

    public void Push(int item)
    {
        if (top == maxSize - 1)
        {
            Console.WriteLine("Stack is full. Cannot push item.");
            return;
        }
        
        stackArray[++top] = item;
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty. Cannot pop item.");
            return -1;
        }

        return stackArray[top--];
    }

    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty.");
            return -1;
        }

        return stackArray[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
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

        Console.WriteLine("Popped item: " + stack.Pop());
        Console.WriteLine("Peeked item: " + stack.Peek());
    }
}
