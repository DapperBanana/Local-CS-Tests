
using System;
using System.Collections.Generic;

class FlightReservationSystem
{
    static List<string> availableFlights = new List<string> { "Flight 1 - New York to Los Angeles", "Flight 2 - Chicago to Miami", "Flight 3 - San Francisco to Seattle" };
    static List<string> reservedFlights = new List<string>();

    static void Main()
    {
        Console.WriteLine("Welcome to the Flight Reservation System!\n");

        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowAvailableFlights();
                    break;
                case "2":
                    ReserveFlight();
                    break;
                case "3":
                    ShowReservedFlights();
                    break;
                case "4":
                    CancelReservation();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the Flight Reservation System. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Show available flights");
        Console.WriteLine("2. Reserve a flight");
        Console.WriteLine("3. Show reserved flights");
        Console.WriteLine("4. Cancel reservation");
        Console.WriteLine("5. Quit\n");
        Console.Write("Enter your choice: ");
    }

    static void ShowAvailableFlights()
    {
        Console.WriteLine("\nAvailable Flights:");
        foreach (string flight in availableFlights)
        {
            Console.WriteLine(flight);
        }
    }

    static void ReserveFlight()
    {
        Console.Write("\nEnter the number of the flight you want to reserve: ");
        int flightNumber = int.Parse(Console.ReadLine());

        if (flightNumber >= 1 && flightNumber <= availableFlights.Count)
        {
            string selectedFlight = availableFlights[flightNumber - 1];
            reservedFlights.Add(selectedFlight);
            availableFlights.Remove(selectedFlight);

            Console.WriteLine($"Flight {flightNumber} has been reserved successfully.");
        }
        else
        {
            Console.WriteLine("Invalid flight number. Please try again.");
        }
    }

    static void ShowReservedFlights()
    {
        Console.WriteLine("\nReserved Flights:");
        foreach (string flight in reservedFlights)
        {
            Console.WriteLine(flight);
        }
    }

    static void CancelReservation()
    {
        Console.Write("\nEnter the number of the flight you want to cancel: ");
        int flightNumber = int.Parse(Console.ReadLine());

        if (flightNumber >= 1 && flightNumber <= reservedFlights.Count)
        {
            string selectedFlight = reservedFlights[flightNumber - 1];
            reservedFlights.Remove(selectedFlight);
            availableFlights.Add(selectedFlight);

            Console.WriteLine($"Reservation for Flight {flightNumber} has been cancelled.");
        }
        else
        {
            Console.WriteLine("Invalid flight number. Please try again.");
        }
    }
}
