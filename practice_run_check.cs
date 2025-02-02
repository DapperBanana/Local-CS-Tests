
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<DateTime, List<string>> calendar = new Dictionary<DateTime, List<string>>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. View events for a specific date");
            Console.WriteLine("2. Add event to a specific date");
            Console.WriteLine("3. Remove event from a specific date");
            Console.WriteLine("4. Exit");
            Console.Write("Enter option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ViewEvents();
                    break;
                case "2":
                    AddEvent();
                    break;
                case "3":
                    RemoveEvent();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ViewEvents()
    {
        Console.Write("Enter date (MM/dd/yyyy): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        if (calendar.ContainsKey(date))
        {
            Console.WriteLine("Events for {0}:", date.ToShortDateString());
            foreach (string eventItem in calendar[date])
            {
                Console.WriteLine("- " + eventItem);
            }
        }
        else
        {
            Console.WriteLine("No events found for {0}.", date.ToShortDateString());
        }
    }

    static void AddEvent()
    {
        Console.Write("Enter date (MM/dd/yyyy): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        if (!calendar.ContainsKey(date))
        {
            calendar[date] = new List<string>();
        }

        Console.Write("Enter event description: ");
        string eventDescription = Console.ReadLine();

        calendar[date].Add(eventDescription);
        Console.WriteLine("Event added successfully!");
    }

    static void RemoveEvent()
    {
        Console.Write("Enter date (MM/dd/yyyy): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        if (calendar.ContainsKey(date))
        {
            Console.WriteLine("Events for {0}:", date.ToShortDateString());
            foreach (string eventItem in calendar[date])
            {
                Console.WriteLine("- " + eventItem);
            }

            Console.Write("Enter event number to remove: ");
            int eventIndex = int.Parse(Console.ReadLine());
            calendar[date].RemoveAt(eventIndex - 1);

            Console.WriteLine("Event removed successfully!");
        }
        else
        {
            Console.WriteLine("No events found for {0}.", date.ToShortDateString());
        }
    }
}
