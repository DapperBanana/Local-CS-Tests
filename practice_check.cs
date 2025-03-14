
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

    public void InsertFront(int data)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
    }

    public void InsertEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node lastNode = head;
        while (lastNode.next != null)
        {
            lastNode = lastNode.next;
        }

        lastNode.next = newNode;
    }

    public void Delete(int data)
    {
        Node prev = null;
        Node current = head;

        while (current != null && current.data != data)
        {
            prev = current;
            current = current.next;
        }

        if (current == null)
        {
            return;
        }

        if (prev == null)
        {
            head = current.next;
        }
        else
        {
            prev.next = current.next;
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

    static void Main()
    {
        LinkedList linkedList = new LinkedList();

        // Insert elements at the front
        linkedList.InsertFront(3);
        linkedList.InsertFront(2);
        linkedList.InsertFront(1);

        Console.WriteLine("Linked list after inserting at the front:");
        linkedList.PrintList();

        // Insert elements at the end
        linkedList.InsertEnd(4);
        linkedList.InsertEnd(5);

        Console.WriteLine("Linked list after inserting at the end:");
        linkedList.PrintList();

        // Delete an element
        linkedList.Delete(3);

        Console.WriteLine("Linked list after deleting 3:");
        linkedList.PrintList();
    }
}
