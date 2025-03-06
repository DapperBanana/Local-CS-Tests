
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

    public void AddNode(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
        }
    }

    public void DisplayList()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }

    public void DeleteNode(int value)
    {
        Node current = head;
        Node previous = null;

        while (current != null && current.data != value)
        {
            previous = current;
            current = current.next;
        }

        if (current != null)
        {
            if (previous == null)
            {
                head = current.next;
            }
            else
            {
                previous.next = current.next;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        
        list.AddNode(1);
        list.AddNode(2);
        list.AddNode(3);
        
        Console.WriteLine("Linked List:");
        list.DisplayList();
        
        list.DeleteNode(2);
        
        Console.WriteLine("Linked List after deleting node with value 2:");
        list.DisplayList();
    }
}
