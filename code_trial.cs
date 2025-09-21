
using System;
using System.Collections.Generic;

namespace FlightReservationSystem
{
    class Program
    {
        static List<string> seats = new List<string>(new string[] { "A1", "A2", "A3", "A4", "B1", "B2", "B3", "B4", "C1", "C2", "C3", "C4" });
        static Dictionary<string, string> reservations = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Flight Reservation System");
                Console.WriteLine("1. View available seats");
                Console.WriteLine("2. Make a reservation");
                Console.WriteLine("3. View reservations");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ViewAvailableSeats();
                        break;
                    case 2:
                        MakeReservation();
                        break;
                    case 3:
                        ViewReservations();
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

        static void ViewAvailableSeats()
        {
            Console.WriteLine("Available Seats:");
            foreach (string seat in seats)
            {
                if (!reservations.ContainsValue(seat))
                {
                    Console.WriteLine(seat);
                }
            }
        }

        static void MakeReservation()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Available Seats:");
            foreach (string seat in seats)
            {
                if (!reservations.ContainsValue(seat))
                {
                    Console.WriteLine(seat);
                }
            }

            Console.WriteLine("Enter the seat you want to reserve:");
            string reservedSeat = Console.ReadLine();

            if (seats.Contains(reservedSeat) && !reservations.ContainsValue(reservedSeat))
            {
                reservations.Add(name, reservedSeat);
                Console.WriteLine("Reservation successful!");
            }
            else
            {
                Console.WriteLine("Invalid seat selection. Please try again.");
            }
        }

        static void ViewReservations()
        {
            Console.WriteLine("Reservations:");
            foreach (KeyValuePair<string, string> reservation in reservations)
            {
                Console.WriteLine("Name: " + reservation.Key + " | Seat: " + reservation.Value);
            }
        }
    }
}
