
using System;

class Stack
{
    private int[] stack;
    private int top;
    private int size;

    public Stack(int size)
    {
        this.size = size;
        stack = new int[size];
        top = -1;
    }

    public void Push(int item)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack is full");
            return;
        }

        stack[++top] = item;
        Console.WriteLine($"{item} pushed to stack");
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }

        int item = stack[top--];
        Console.WriteLine($"{item} popped from stack");
        return item;
    }

    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }

        return stack[top];
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
        stack.Push(5);

        stack.Push(6);

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();

        stack.Pop();
    }
}
