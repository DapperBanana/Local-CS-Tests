
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
        head = null;
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

    public void DisplayList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
    }

    public void DeleteNode(int value)
    {
        if (head == null)
        {
            return;
        }

        if (head.data == value)
        {
            head = head.next;
            return;
        }

        Node current = head;
        while (current.next != null)
        {
            if (current.next.data == value)
            {
                current.next = current.next.next;
                return;
            }
            current = current.next;
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
        list.AddNode(4);

        Console.WriteLine("Initial linked list:");
        list.DisplayList();

        Console.WriteLine("\nDeleting node with value 2:");
        list.DeleteNode(2);
        list.DisplayList();
    }
}
