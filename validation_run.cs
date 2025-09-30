
using System;

public class Stack
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
            Console.WriteLine("Stack is full, cannot push more items.");
        }
        else
        {
            items[++top] = item;
            Console.WriteLine("Pushed item: " + item);
        }
    }

    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty, nothing to pop.");
        }
        else
        {
            Console.WriteLine("Popped item: " + items[top--]);
        }
    }

    public void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty, nothing to peek.");
        }
        else
        {
            Console.WriteLine("Top item: " + items[top]);
        }
    }

    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty.");
        }
        else
        {
            Console.WriteLine("Stack items:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
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

        stack.Peek();
    }
}
