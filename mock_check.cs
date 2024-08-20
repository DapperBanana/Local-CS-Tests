
using System;

public class Node
{
    public int data;
    public Node next;

    public Node(int d)
    {
        data = d;
        next = null;
    }
}

public class LinkedList
{
    private Node head;

    public void InsertAtBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
    }

    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node last = head;

        while (last.next != null)
        {
            last = last.next;
        }

        last.next = newNode;
    }

    public void PrintList()
    {
        Node current = head;

        Console.Write("Linked list: ");

        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();

        list.InsertAtEnd(1);
        list.InsertAtEnd(2);
        list.InsertAtEnd(3);

        list.PrintList();

        list.InsertAtBeginning(4);

        list.PrintList();
    }
}
