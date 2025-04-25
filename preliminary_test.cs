
using System;
using System.Collections.Generic;

namespace FlightReservationSystem
{
    class Program
    {
        static List<string> availableSeats = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };
        static List<string> bookedSeats = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Flight Reservation System");
                Console.WriteLine("1. View Available Seats");
                Console.WriteLine("2. Book a Seat");
                Console.WriteLine("3. Cancel Booking");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ViewAvailableSeats();
                        break;
                    case 2:
                        BookSeat();
                        break;
                    case 3:
                        CancelBooking();
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

        static void ViewAvailableSeats()
        {
            Console.WriteLine("Available Seats:");
            foreach (string seat in availableSeats)
            {
                Console.WriteLine(seat);
            }
        }

        static void BookSeat()
        {
            Console.WriteLine("Enter the seat number you want to book:");
            string seatNumber = Console.ReadLine();

            if (availableSeats.Contains(seatNumber))
            {
                availableSeats.Remove(seatNumber);
                bookedSeats.Add(seatNumber);
                Console.WriteLine($"Seat {seatNumber} booked successfully.");
            }
            else
            {
                Console.WriteLine("Seat is not available. Please try again.");
            }
        }

        static void CancelBooking()
        {
            Console.WriteLine("Enter the seat number you want to cancel booking for:");
            string seatNumber = Console.ReadLine();

            if (bookedSeats.Contains(seatNumber))
            {
                bookedSeats.Remove(seatNumber);
                availableSeats.Add(seatNumber);
                Console.WriteLine($"Booking for seat {seatNumber} cancelled successfully.");
            }
            else
            {
                Console.WriteLine("Invalid seat number. Please try again.");
            }
        }
    }
}
