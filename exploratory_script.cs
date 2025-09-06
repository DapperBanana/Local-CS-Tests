
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

    public void Push(int value)
    {
        if (top == maxSize - 1)
        {
            Console.WriteLine("Stack overflow");
        }
        else
        {
            stackArray[++top] = value;
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
            return stackArray[top--];
        }
    }

    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stackArray[i]);
            }
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

        stack.Display();

        stack.Pop();

        stack.Display();
    }
}
