
using System;
using System.Collections.Generic;

class FlightReservationSystem
{
    static List<string> availableFlights = new List<string>
    {
        "Flight 1 - New York to Los Angeles",
        "Flight 2 - Chicago to Miami",
        "Flight 3 - San Francisco to Seattle"
    };

    static List<string> reservedFlights = new List<string>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Flight Reservation System");
            Console.WriteLine("Available Flights:");
            foreach (string flight in availableFlights)
            {
                Console.WriteLine(flight);
            }

            Console.WriteLine("\n1. Book a flight");
            Console.WriteLine("2. Cancel a reservation");
            Console.WriteLine("3. View reserved flights");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    BookFlight();
                    break;
                case 2:
                    CancelReservation();
                    break;
                case 3:
                    ViewReservedFlights();
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void BookFlight()
    {
        Console.WriteLine("Enter the flight number you want to book:");
        int flightNumber = int.Parse(Console.ReadLine());

        if (flightNumber > 0 && flightNumber <= availableFlights.Count)
        {
            string flight = availableFlights[flightNumber - 1];
            reservedFlights.Add(flight);
            availableFlights.RemoveAt(flightNumber - 1);
            Console.WriteLine("Flight booked successfully!");
        }
        else
        {
            Console.WriteLine("Invalid flight number. Please try again.");
        }
    }

    static void CancelReservation()
    {
        Console.WriteLine("Enter the flight number you want to cancel:");
        int flightNumber = int.Parse(Console.ReadLine());

        if (flightNumber > 0 && flightNumber <= reservedFlights.Count)
        {
            string flight = reservedFlights[flightNumber - 1];
            availableFlights.Add(flight);
            reservedFlights.RemoveAt(flightNumber - 1);
            Console.WriteLine("Flight reservation canceled successfully!");
        }
        else
        {
            Console.WriteLine("Invalid flight number. Please try again.");
        }
    }

    static void ViewReservedFlights()
    {
        Console.WriteLine("Reserved Flights:");
        foreach (string flight in reservedFlights)
        {
            Console.WriteLine(flight);
        }
    }
}
