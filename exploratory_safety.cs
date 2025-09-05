
using System;

namespace SwapValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine($"Before swapping: x = {x}, y = {y}");

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"After swapping: x = {x}, y = {y}");
        }
    }
}
