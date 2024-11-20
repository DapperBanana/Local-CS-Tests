
using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class LinkedList
{
    private Node head;

    public LinkedList()
    {
        this.head = null;
    }

    public void AddNode(int data)
    {
        Node newNode = new Node(data);

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

    public void PrintList()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }

        Console.WriteLine();
    }

    public void DeleteNode(int data)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.data == data)
        {
            head = head.next;
            return;
        }

        Node current = head;
        Node previous = null;

        while (current != null && current.data != data)
        {
            previous = current;
            current = current.next;
        }

        if (current == null)
        {
            Console.WriteLine("Data not found.");
            return;
        }

        previous.next = current.next;
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

        Console.WriteLine("Initial List:");
        list.PrintList();

        list.DeleteNode(2);
        Console.WriteLine("List after deleting node with data 2:");
        list.PrintList();
    }
}
