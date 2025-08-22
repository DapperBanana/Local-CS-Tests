
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
            return;
        }

        if (head.data == data)
        {
            head = head.next;
            return;
        }

        Node current = head;
        while (current.next != null)
        {
            if (current.next.data == data)
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

        Console.WriteLine("Initial List:");
        list.PrintList();

        list.DeleteNode(2);

        Console.WriteLine("List after deleting node with data 2:");
        list.PrintList();
    }
}
