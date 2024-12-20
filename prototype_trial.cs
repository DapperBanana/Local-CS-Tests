
using System;

public class Node
{
    public int data;
    public Node next;
}

public class LinkedList
{
    private Node head;

    public void Insert(int data)
    {
        Node newNode = new Node();
        newNode.data = data;
        newNode.next = head;
        head = newNode;
    }

    public void Print()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }

    public void Delete(int data)
    {
        Node current = head;
        Node prev = null;

        while (current != null && current.data != data)
        {
            prev = current;
            current = current.next;
        }

        if (current == null)
        {
            Console.WriteLine("Element not found in the linked list");
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

    public static void Main()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.Insert(1);
        linkedList.Insert(2);
        linkedList.Insert(3);
        linkedList.Insert(4);

        Console.WriteLine("Original Linked List:");
        linkedList.Print();

        linkedList.Delete(3);

        Console.WriteLine("Linked List after deleting element '3':");
        linkedList.Print();
    }
}
