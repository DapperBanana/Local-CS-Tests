
using System;

public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

public class LinkedList
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
        Node current = head;
        Node previous = null;

        while (current != null && current.data != data)
        {
            previous = current;
            current = current.next;
        }

        if (current == null)
        {
            Console.WriteLine("Node not found");
            return;
        }

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

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();

        list.AddNode(1);
        list.AddNode(2);
        list.AddNode(3);
        list.AddNode(4);

        list.PrintList();

        list.DeleteNode(3);

        list.PrintList();
    }
}
