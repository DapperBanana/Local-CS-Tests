
using System;
using System.Collections.Generic;

class Flight
{
    public string FlightNumber { get; }
    public string Origin { get; }
    public string Destination { get; }
    public int AvailableSeats { get; set; }
    public List<string> Passengers { get; }

    public Flight(string flightNumber, string origin, string destination, int availableSeats)
    {
        FlightNumber = flightNumber;
        Origin = origin;
        Destination = destination;
        AvailableSeats = availableSeats;
        Passengers = new List<string>();
    }
}

class Program
{
    static List<Flight> flights = new List<Flight>();

    static void Main()
    {
        flights.Add(new Flight("ABC123", "New York", "Los Angeles", 50));
        flights.Add(new Flight("DEF456", "Chicago", "Miami", 30));

        Console.WriteLine("Welcome to the Flight Reservation System\n");

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. View Available Flights");
            Console.WriteLine("2. Make Reservation");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewAvailableFlights();
                    break;
                case 2:
                    MakeReservation();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ViewAvailableFlights()
    {
        Console.WriteLine("Available Flights:");
        foreach (var flight in flights)
        {
            Console.WriteLine($"Flight Number: {flight.FlightNumber}, Origin: {flight.Origin}, Destination: {flight.Destination}, Available Seats: {flight.AvailableSeats}");
        }
    }

    static void MakeReservation()
    {
        Console.WriteLine("Enter the flight number:");
        string flightNumber = Console.ReadLine();

        Flight selectedFlight = flights.Find(f => f.FlightNumber == flightNumber);

        if (selectedFlight == null)
        {
            Console.WriteLine("Invalid flight number.");
            return;
        }

        if (selectedFlight.AvailableSeats > 0)
        {
            Console.WriteLine("Enter passenger name:");
            string passengerName = Console.ReadLine();

            selectedFlight.Passengers.Add(passengerName);
            selectedFlight.AvailableSeats--;

            Console.WriteLine("Reservation successful!");
        }
        else
        {
            Console.WriteLine("Sorry, no available seats on this flight.");
        }
    }
}
