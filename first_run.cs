
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
    public Node head;

    public LinkedList()
    {
        head = null;
    }

    public void InsertFront(int value)
    {
        Node newNode = new Node(value);
        newNode.next = head;
        head = newNode;
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

    public void Delete(int key)
    {
        Node temp = head;
        Node prev = null;

        if (temp != null && temp.data == key)
        {
            head = temp.next;
            return;
        }

        while (temp != null && temp.data != key)
        {
            prev = temp;
            temp = temp.next;
        }

        if (temp == null) return;

        prev.next = temp.next;
    }
}

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        list.InsertFront(3);
        list.InsertFront(2);
        list.InsertFront(1);

        Console.WriteLine("Initial list:");
        list.PrintList();

        list.Delete(2);
        Console.WriteLine("After deleting 2:");
        list.PrintList();
    }
}
