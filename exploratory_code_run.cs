
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
    public Node head;

    public LinkedList()
    {
        this.head = null;
    }

    public void Insert(int data)
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
            Console.WriteLine("Element not found in the list");
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

        Console.WriteLine("Element deleted successfully");
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);

        Console.WriteLine("Original List:");
        list.Display();

        list.Delete(20);

        Console.WriteLine("List after deleting element:");
        list.Display();
    }
}
