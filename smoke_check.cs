
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
            Console.WriteLine("Stack overflow");
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
            Console.WriteLine("Stack underflow");
            return -1;
        }
        else
        {
            int value = stackArray[top--];
            Console.WriteLine(value + " popped from stack");
            return value;
        }
    }

    public void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack empty");
        }
        else
        {
            Console.WriteLine("Top element of stack is: " + stackArray[top]);
        }
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

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Peek();

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();

        Console.WriteLine("Is stack empty? " + stack.IsEmpty());
    }
}
