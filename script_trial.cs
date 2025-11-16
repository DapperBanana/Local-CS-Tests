
using System;

class Stack
{
    private int[] items;
    private int top;
    
    public Stack(int size)
    {
        items = new int[size];
        top = -1;
    }
    
    public void Push(int item)
    {
        if (top == items.Length - 1)
        {
            Console.WriteLine("Stack overflow");
        }
        else
        {
            items[++top] = item;
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
            return items[top--];
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
        
        Console.WriteLine(stack.Pop()); // 3
        Console.WriteLine(stack.Pop()); // 2
        Console.WriteLine(stack.Pop()); // 1
        Console.WriteLine(stack.Pop()); // Stack underflow
        
    }
}
