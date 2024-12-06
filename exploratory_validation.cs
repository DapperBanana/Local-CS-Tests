
using System;
using System.Collections.Generic;

class Flight
{
    public string FlightNumber { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public int Capacity { get; set; }
    public int SeatsBooked { get; set; }

    public Flight(string flightNumber, string from, string to, int capacity)
    {
        FlightNumber = flightNumber;
        From = from;
        To = to;
        Capacity = capacity;
        SeatsBooked = 0;
    }
}

class Program
{
    static List<Flight> flights = new List<Flight>();

    public static void PrintFlights()
    {
        foreach (Flight flight in flights)
        {
            Console.WriteLine($"Flight Number: {flight.FlightNumber}, From: {flight.From}, To: {flight.To}, Seats Booked: {flight.SeatsBooked}/{flight.Capacity}");
        }
    }

    public static void BookFlight(string flightNumber)
    {
        Flight flight = flights.Find(f => f.FlightNumber == flightNumber);

        if (flight != null)
        {
            if (flight.SeatsBooked < flight.Capacity)
            {
                flight.SeatsBooked++;
                Console.WriteLine("Flight booked successfully!");
            }
            else
            {
                Console.WriteLine("Flight is fully booked!");
            }
        }
        else
        {
            Console.WriteLine("Flight not found!");
        }
    }

    static void Main()
    {
        flights.Add(new Flight("ABC123", "New York", "Los Angeles", 100));
        flights.Add(new Flight("DEF456", "Chicago", "Miami", 150));
        flights.Add(new Flight("GHI789", "San Francisco", "Seattle", 120));

        while (true)
        {
            Console.WriteLine("Available Flights:");
            PrintFlights();

            Console.Write("Enter the flight number to book a flight (or type 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            BookFlight(input);
        }
    }
}
