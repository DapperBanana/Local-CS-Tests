
using System;

class Node
{
    public int data;
    public Node next;
    
    public Node(int value)
    {
        data = value;
        next = null;
    }
}

class LinkedList
{
    private Node head;
    
    public LinkedList()
    {
        head = null;
    }
    
    public void AddToFront(int value)
    {
        Node newNode = new Node(value);
        newNode.next = head;
        head = newNode;
    }
    
    public void AddToEnd(int value)
    {
        if (head == null)
        {
            head = new Node(value);
        }
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(value);
        }
    }
    
    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
    
    public void Delete(int value)
    {
        if (head.data == value)
        {
            head = head.next;
        }
        else
        {
            Node prev = null;
            Node current = head;
            while (current != null && current.data != value)
            {
                prev = current;
                current = current.next;
            }
            if (current != null)
            {
                prev.next = current.next;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        
        list.AddToFront(3);
        list.AddToFront(2);
        list.AddToEnd(4);
        list.AddToEnd(5);
        
        Console.WriteLine("Linked list elements:");
        list.Display();
        
        list.Delete(4);
        list.Delete(2);
        
        Console.WriteLine("After deleting some elements:");
        list.Display();
    }
}
