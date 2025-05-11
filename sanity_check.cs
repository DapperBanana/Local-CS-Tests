
using System;

class CalendarProgram
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based Calendar!");
        
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. View Calendar");
            Console.WriteLine("2. Add Event");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewCalendar();
                    break;
                case 2:
                    AddEvent();
                    break;
                case 3:
                    Console.WriteLine("Exiting program.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ViewCalendar()
    {
        Console.WriteLine("January 2022");
        // Add code to display calendar events
    }

    static void AddEvent()
    {
        Console.WriteLine("Enter event details:");
        string eventDetails = Console.ReadLine();
        // Add code to store event details in calendar
        Console.WriteLine("Event added successfully!");
    }
}
