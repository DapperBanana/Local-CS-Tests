
using System;

class Node
{
    public int data;
    public Node next;
    
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class LinkedList
{
    public Node head;
    
    public void Insert(int data)
    {
        Node newNode = new Node(data);
        
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node lastNode = head;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = newNode;
        }
    }
    
    public void Display()
    {
        Node currentNode = head;
        
        while (currentNode != null)
        {
            Console.Write(currentNode.data + " ");
            currentNode = currentNode.next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        LinkedList linkedList = new LinkedList();
        
        linkedList.Insert(1);
        linkedList.Insert(2);
        linkedList.Insert(3);
        
        Console.WriteLine("Linked List:");
        linkedList.Display();
    }
}
