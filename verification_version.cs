
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

    public void RemoveNode(int data)
    {
        Node current = head;
        Node previous = null;

        while (current != null)
        {
            if (current.data == data)
            {
                if (previous == null)
                {
                    head = current.next;
                }
                else
                {
                    previous.next = current.next;
                }
                return;
            }

            previous = current;
            current = current.next;
        }
    }

    public void PrintLinkedList()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        LinkedList list = new LinkedList();

        list.AddNode(1);
        list.AddNode(2);
        list.AddNode(3);
        list.AddNode(4);

        list.PrintLinkedList();

        list.RemoveNode(3);

        list.PrintLinkedList();
    }
}
