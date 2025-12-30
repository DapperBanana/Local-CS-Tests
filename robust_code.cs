using System;
using System.Collections.Generic;

class FlightReservationSystem
{
    class Flight
    {
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public int Capacity { get; set; }
        public List<string> Passengers { get; set; }

        public Flight(string flightNumber, string destination, int capacity)
        {
            FlightNumber = flightNumber;
            Destination = destination;
            Capacity = capacity;
            Passengers = new List<string>();
        }

        public bool IsFull()
        {
            return Passengers.Count >= Capacity;
        }
    }

    static List<Flight> flights = new List<Flight>();

    static void Main()
    {
        InitializeFlights();

        while (true)
        {
            Console.WriteLine("\n--- Flight Reservation System ---");
            Console.WriteLine("1. View Flights");
            Console.WriteLine("2. Book a Flight");
            Console.WriteLine("3. Cancel Reservation");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewFlights();
                    break;
                case "2":
                    BookFlight();
                    break;
                case "3":
                    CancelReservation();
                    break;
                case "4":
                    Console.WriteLine("Exiting the system. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void InitializeFlights()
    {
        flights.Add(new Flight("AA101", "New York", 5));
        flights.Add(new Flight("BA201", "London", 3));
        flights.Add(new Flight("CA301", "Paris", 4));
    }

    static void ViewFlights()
    {
        Console.WriteLine("\nAvailable Flights:");
        foreach (var flight in flights)
        {
            Console.WriteLine($"Flight {flight.FlightNumber} to {flight.Destination} - Capacity: {flight.Capacity} - Booked: {flight.Passengers.Count}");
            if (flight.Passengers.Count > 0)
            {
                Console.WriteLine(" Passengers: " + string.Join(", ", flight.Passengers));
            }
            else
            {
                Console.WriteLine(" Passengers: None");
            }
        }
    }

    static void BookFlight()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Select a flight to book:");
        for (int i = 0; i < flights.Count; i++)
        {
            var flight = flights[i];
            Console.WriteLine($"{i + 1}. {flight.FlightNumber} to {flight.Destination} (Booked: {flight.Passengers.Count}/{flight.Capacity})");
        }

        Console.Write("Enter flight number: ");
        if (int.TryParse(Console.ReadLine(), out int flightChoice) && flightChoice >= 1 && flightChoice <= flights.Count)
        {
            var selectedFlight = flights[flightChoice - 1];
            if (selectedFlight.IsFull())
            {
                Console.WriteLine("Sorry, this flight is fully booked.");
            }
            else if (selectedFlight.Passengers.Contains(name))
            {
                Console.WriteLine("You have already booked this flight.");
            }
            else
            {
                selectedFlight.Passengers.Add(name);
                Console.WriteLine($"Reservation successful! {name} is now booked on flight {selectedFlight.FlightNumber}.");
            }
        }
        else
        {
            Console.WriteLine("Invalid flight selection.");
        }
    }

    static void CancelReservation()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Select a flight to cancel reservation:");
        List<Flight> flightsWithPassenger = new List<Flight>();
        for (int i = 0; i < flights.Count; i++)
        {
            if (flights[i].Passengers.Contains(name))
            {
                flightsWithPassenger.Add(flights[i]);
                Console.WriteLine($"{flightsWithPassenger.Count}. {flights[i].FlightNumber} to {flights[i].Destination}");
            }
        }

        if (flightsWithPassenger.Count == 0)
        {
            Console.WriteLine("You have no reservations to cancel.");
            return;
        }

        if (int.TryParse(Console.ReadLine(), out int cancelChoice) && cancelChoice >= 1 && cancelChoice <= flightsWithPassenger.Count)
        {
            var flightToCancel = flightsWithPassenger[cancelChoice - 1];
            flightToCancel.Passengers.Remove(name);
            Console.WriteLine($"Your reservation on flight {flightToCancel.FlightNumber} has been canceled.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}