
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
            Console.WriteLine("Stack is full");
        }
        else
        {
            stackArray[++top] = item;
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
            return stackArray[top--];
        }
    }

    public void Display()
    {
        Console.Write("Stack elements: ");
        for (int i = 0; i <= top; i++)
        {
            Console.Write(stackArray[i] + " ");
        }
        Console.WriteLine();
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
        stack.Display();

        int poppedItem = stack.Pop();
        Console.WriteLine("Popped item: " + poppedItem);

        stack.Push(40);
        stack.Display();
    }
}
