
using System;
using System.Collections.Generic;

class Flight
{
    public string FlightNumber { get; set; }
    public string DepartureCity { get; set; }
    public string DestinationCity { get; set; }
    public int AvailableSeats { get; set; }
}

class Reservation
{
    public string PassengerName { get; set; }
    public string FlightNumber { get; set; }
}

class Program
{
    static List<Flight> flights = new List<Flight>();
    static List<Reservation> reservations = new List<Reservation>();

    static void Main()
    {
        flights.Add(new Flight { FlightNumber = "F001", DepartureCity = "New York", DestinationCity = "Los Angeles", AvailableSeats = 10 });
        flights.Add(new Flight { FlightNumber = "F002", DepartureCity = "Chicago", DestinationCity = "Miami", AvailableSeats = 5 });
        
        Console.WriteLine("Welcome to the Flight Reservation System");

        while (true)
        {
            Console.WriteLine("\n1. View Available Flights\n2. Make a Reservation\n3. View Reservations\n4. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewFlights();
                    break;
                case 2:
                    MakeReservation();
                    break;
                case 3:
                    ViewReservations();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        }
    }

    static void ViewFlights()
    {
        Console.WriteLine("\nAvailable Flights:");
        foreach (var flight in flights)
        {
            Console.WriteLine($"Flight Number: {flight.FlightNumber}, Departure City: {flight.DepartureCity}, Destination City: {flight.DestinationCity}, Available Seats: {flight.AvailableSeats}");
        }
    }

    static void MakeReservation()
    {
        Console.Write("\nEnter your name: ");
        string passengerName = Console.ReadLine();

        Console.Write("Enter the flight number you want to book: ");
        string flightNumber = Console.ReadLine();

        Flight selectedFlight = flights.Find(f => f.FlightNumber == flightNumber);
        if (selectedFlight == null)
        {
            Console.WriteLine("Invalid flight number");
            return;
        }

        if (selectedFlight.AvailableSeats > 0)
        {
            selectedFlight.AvailableSeats--;
            reservations.Add(new Reservation { PassengerName = passengerName, FlightNumber = flightNumber });
            Console.WriteLine("Reservation successful!");
        }
        else
        {
            Console.WriteLine("Sorry, this flight is fully booked");
        }
    }

    static void ViewReservations()
    {
        Console.WriteLine("\nYour Reservations:");
        foreach (var reservation in reservations)
        {
            Console.WriteLine($"Passenger Name: {reservation.PassengerName}, Flight Number: {reservation.FlightNumber}");
        }
    }
}
