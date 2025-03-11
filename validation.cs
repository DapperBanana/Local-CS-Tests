
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, string> flights = new Dictionary<int, string>()
    {
        {1, "Flight 1 - New York to Los Angeles"},
        {2, "Flight 2 - Chicago to Miami"},
        {3, "Flight 3 - San Francisco to Seattle"}
    };

    static Dictionary<int, List<string>> reservations = new Dictionary<int, List<string>>()
    {
        {1, new List<string>()},
        {2, new List<string>()},
        {3, new List<string>()}
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Available Flights:");
            foreach (var flight in flights)
            {
                Console.WriteLine($"{flight.Key}: {flight.Value}");
            }

            Console.Write("\nEnter the flight number to make a reservation (or 0 to exit): ");
            int flightNumber = int.Parse(Console.ReadLine());

            if (flightNumber == 0)
            {
                break;
            }
            else if (flights.ContainsKey(flightNumber))
            {
                Console.WriteLine($"You have selected {flights[flightNumber]}.");

                Console.Write("Enter passenger name: ");
                string passengerName = Console.ReadLine();

                reservations[flightNumber].Add(passengerName);
                Console.WriteLine("Reservation successful!\n");
            }
            else
            {
                Console.WriteLine("Invalid flight number selected. Please try again.\n");
            }
        }

        Console.WriteLine("Here are the reservations:");

        foreach (var flight in reservations)
        {
            Console.WriteLine(flights[flight.Key]);
            foreach (var passenger in flight.Value)
            {
                Console.WriteLine($"- {passenger}");
            }
            Console.WriteLine();
        }
    }
}
