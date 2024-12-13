
using System;
using System.Collections.Generic;

namespace FlightReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> flights = new Dictionary<string, string>
            {
                { "F001", "New York to Los Angeles" },
                { "F002", "Chicago to Miami" },
                { "F003", "Boston to Seattle" }
            };

            Dictionary<string, int> availableSeats = new Dictionary<string, int>
            {
                { "F001", 100 },
                { "F002", 75 },
                { "F003", 50 }
            };

            string userInput;
            do
            {
                Console.WriteLine("Available Flights:");
                foreach (var flight in flights)
                {
                    Console.WriteLine($"{flight.Key} - {flight.Value} ({availableSeats[flight.Key]} seats available)");
                }

                Console.Write("Enter the flight number to make a reservation or 'exit' to quit: ");
                userInput = Console.ReadLine();

                if (flights.ContainsKey(userInput))
                {
                    if (availableSeats[userInput] > 0)
                    {
                        availableSeats[userInput]--;
                        Console.WriteLine("Reservation successful!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, no seats available for this flight.");
                    }
                }
                else if (userInput.ToLower() != "exit")
                {
                    Console.WriteLine("Invalid flight number. Please try again.");
                }

            } while (userInput.ToLower() != "exit");

            Console.WriteLine("Thank you for using the Flight Reservation System. Have a nice day!");
        }
    }
}
