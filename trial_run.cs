
using System;
using System.Collections.Generic;

namespace FlightReservationSystem
{
    class Program
    {
        static Dictionary<int, string> flights = new Dictionary<int, string>()
        {
            {1, "Flight 1 - New York to Los Angeles"},
            {2, "Flight 2 - Chicago to Miami"},
            {3, "Flight 3 - Dallas to Seattle"}
        };

        static Dictionary<int, List<string>> reservations = new Dictionary<int, List<string>>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Flight Reservation System");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. View available flights");
                Console.WriteLine("2. Make a reservation");
                Console.WriteLine("3. View reservations");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
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
                        Console.WriteLine("Thank you for using the Flight Reservation System. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void ViewFlights()
        {
            Console.WriteLine("\nAvailable Flights:");
            foreach (var flight in flights)
            {
                Console.WriteLine($"{flight.Key}. {flight.Value}");
            }
        }

        static void MakeReservation()
        {
            Console.WriteLine("\nMake Reservation:");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Choose a flight (by number): ");
            int flightNumber = Convert.ToInt32(Console.ReadLine());

            if (flights.ContainsKey(flightNumber))
            {
                if (!reservations.ContainsKey(flightNumber))
                {
                    reservations[flightNumber] = new List<string>();
                }
                reservations[flightNumber].Add(name);
                Console.WriteLine("Reservation successful!");
            }
            else
            {
                Console.WriteLine("Invalid flight number. Please try again.");
            }
        }

        static void ViewReservations()
        {
            Console.WriteLine("\nReservations:");
            foreach (var reservation in reservations)
            {
                Console.WriteLine($"{flights[reservation.Key]}:");
                foreach (var passenger in reservation.Value)
                {
                    Console.WriteLine($"- {passenger}");
                }
            }
        }
    }
}
