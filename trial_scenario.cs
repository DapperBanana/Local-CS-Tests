
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

    public void RemoveNode(int value)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.data == value)
        {
            head = head.next;
        }
        else
        {
            Node current = head;
            Node previous = null;

            while (current != null && current.data != value)
            {
                previous = current;
                current = current.next;
            }

            if (current == null)
            {
                Console.WriteLine("Value not found in the list");
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
        list.AddNode(4);
        list.AddNode(5);

        list.Display();

        list.RemoveNode(3);
        list.RemoveNode(5);

        list.Display();
    }
}
