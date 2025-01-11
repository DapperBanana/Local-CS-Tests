
using System;
using System.Collections.Generic;

namespace FlightReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> flights = new Dictionary<int, string>();
            flights.Add(1, "Flight 1 - New York to Los Angeles");
            flights.Add(2, "Flight 2 - Chicago to Miami");
            flights.Add(3, "Flight 3 - San Francisco to Las Vegas");

            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the Flight Reservation System:");
                Console.WriteLine("Available Flights:");
                foreach (var flight in flights)
                {
                    Console.WriteLine($"[{flight.Key}] {flight.Value}");
                }

                Console.WriteLine("Please select a flight number to reserve (0 to exit):");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    running = false;
                }
                else if (flights.ContainsKey(choice))
                {
                    ReserveFlight(flights[choice]);
                }
                else
                {
                    Console.WriteLine("Invalid flight number, please try again.");
                }
            }

            Console.WriteLine("Thank you for using the Flight Reservation System.");
        }

        static void ReserveFlight(string flight)
        {
            Console.WriteLine($"You have reserved {flight}.");
        }
    }
}
