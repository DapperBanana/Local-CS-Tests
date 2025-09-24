
using System;
using System.Collections;

class Stack
{
    private ArrayList stackList;

    public Stack()
    {
        stackList = new ArrayList();
    }

    public void Push(object obj)
    {
        stackList.Add(obj);
    }

    public object Pop()
    {
        if (stackList.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty");
        }
        object obj = stackList[stackList.Count - 1];
        stackList.RemoveAt(stackList.Count - 1);
        return obj;
    }

    public object Peek()
    {
        if (stackList.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty");
        }
        return stackList[stackList.Count - 1];
    }

    public void PrintStack()
    {
        foreach (var item in stackList)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Current stack:");
        stack.PrintStack();

        Console.WriteLine("Popping from stack:");
        Console.WriteLine(stack.Pop());

        Console.WriteLine("Current stack after popping:");
        stack.PrintStack();

        Console.WriteLine("Peek value of stack:");
        Console.WriteLine(stack.Peek());
    }
}
