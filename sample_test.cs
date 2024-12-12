
using System;
using System.Collections.Generic;

namespace FlightReservationSystem
{
    class Program
    {
        static Dictionary<int, bool> seats = new Dictionary<int, bool>();

        static void Main(string[] args)
        {
            InitializeSeats();

            while (true)
            {
                Console.WriteLine("Welcome to the Flight Reservation System!");
                Console.WriteLine("1. View available seats");
                Console.WriteLine("2. Reserve a seat");
                Console.WriteLine("3. Cancel reservation");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ViewAvailableSeats();
                        break;
                    case 2:
                        ReserveSeat();
                        break;
                    case 3:
                        CancelReservation();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void InitializeSeats()
        {
            for (int i = 1; i <= 10; i++)
            {
                seats.Add(i, false);
            }
        }

        static void ViewAvailableSeats()
        {
            foreach (KeyValuePair<int, bool> seat in seats)
            {
                if (!seat.Value)
                {
                    Console.WriteLine($"Seat {seat.Key} is available");
                }
            }
        }

        static void ReserveSeat()
        {
            Console.WriteLine("Enter the seat number you want to reserve:");
            int seatNumber = int.Parse(Console.ReadLine());

            if (seats.ContainsKey(seatNumber) && !seats[seatNumber])
            {
                seats[seatNumber] = true;
                Console.WriteLine($"Seat {seatNumber} reserved successfully.");
            }
            else
            {
                Console.WriteLine("Seat is not available or doesn't exist.");
            }
        }

        static void CancelReservation()
        {
            Console.WriteLine("Enter the seat number you want to cancel reservation:");
            int seatNumber = int.Parse(Console.ReadLine());

            if (seats.ContainsKey(seatNumber) && seats[seatNumber])
            {
                seats[seatNumber] = false;
                Console.WriteLine($"Reservation for seat {seatNumber} cancelled successfully.");
            }
            else
            {
                Console.WriteLine("Seat is not reserved or doesn't exist.");
            }
        }
    }
}
