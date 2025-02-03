
using System;

// Node class for each element in the linked list
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

// Linked list class
public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    // Insert element at the end of the linked list
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

    // Delete element from the linked list
    public void Delete(int data)
    {
        if (head == null)
        {
            Console.WriteLine("Linked list is empty.");
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

        Console.WriteLine("Element not found in linked list.");
    }

    // Display elements in the linked list
    public void Display()
    {
        Console.Write("Linked List: ");

        Node current = head;

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
        LinkedList linkedList = new LinkedList();

        linkedList.Insert(10);
        linkedList.Insert(20);
        linkedList.Insert(30);
        linkedList.Display();

        linkedList.Delete(20);
        linkedList.Display();
    }
}
