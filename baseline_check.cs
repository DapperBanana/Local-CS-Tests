
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
            Console.WriteLine("Stack is full, cannot push item " + item);
            return;
        }

        stackArray[++top] = item;
        Console.WriteLine("Pushed item: " + item);
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty, cannot pop item");
            return -1;
        }

        int poppedItem = stackArray[top];
        top--;
        return poppedItem;
    }

    public void PrintStack()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        Console.WriteLine("Current stack: ");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stackArray[i]);
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
        stack.Push(4);
        stack.PrintStack();

        int poppedItem = stack.Pop();
        Console.WriteLine("Popped item: " + poppedItem);
        stack.PrintStack();

        stack.Push(5);
        stack.Push(6);
        stack.PrintStack();
    }
}
