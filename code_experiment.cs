
using System;

public class Node
{
    public int data;
    public Node next;

    public Node(int value)
    {
        data = value;
        next = null;
    }
}

public class LinkedList
{
    public Node head;

    public LinkedList()
    {
        head = null;
    }

    public void InsertAtEnd(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.next != null)
        {
            current = current.next;
        }

        current.next = newNode;
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
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.data == value)
        {
            head = head.next;
            return;
        }

        Node current = head;
        Node prev = null;

        while (current != null && current.data != value)
        {
            prev = current;
            current = current.next;
        }

        if (current == null)
        {
            Console.WriteLine("Value not found in the list");
            return;
        }

        prev.next = current.next;
    }

    static void Main()
    {
        LinkedList list = new LinkedList();

        list.InsertAtEnd(1);
        list.InsertAtEnd(2);
        list.InsertAtEnd(3);
        list.InsertAtEnd(4);
        list.InsertAtEnd(5);
        list.Display();

        list.Delete(3);
        list.Display();
    }
}
