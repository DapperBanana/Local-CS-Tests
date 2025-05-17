
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
    
    public void AddNode(int value)
    {
        Node newNode = new Node(value);
        
        if(head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
    }
    
    public void PrintList()
    {
        Node temp = head;
        while(temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        Console.WriteLine();
    }
    
    public void DeleteNode(int value)
    {
        Node temp = head;
        Node prev = null;
        
        if(temp != null && temp.data == value)
        {
            head = temp.next;
            return;
        }
        
        while(temp != null && temp.data != value)
        {
            prev = temp;
            temp = temp.next;
        }
        
        if(temp == null)
        {
            return;
        }
        
        prev.next = temp.next;
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
        
        Console.WriteLine("Original List:");
        list.PrintList();
        
        list.DeleteNode(3);
        
        Console.WriteLine("After deleting node with value 3:");
        list.PrintList();
    }
}
