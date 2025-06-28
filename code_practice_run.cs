
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
            Console.WriteLine("Stack is full, cannot push more values.");
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
            Console.WriteLine("Stack is empty, cannot pop any values.");
            return -1;
        }
        else
        {
            return stackArray[top--];
        }
    }

    public void PrintStack()
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
        
        stack.PrintStack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.PrintStack();

        stack.Pop();
        stack.PrintStack();

        stack.Push(40);
        stack.Push(50);
        stack.Push(60); // This will display "Stack is full, cannot push more values."
        
        stack.PrintStack();
    }
}
