using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int totalRolls = 100;

        for (int i = 0; i < totalRolls; i++)
        {
            int die1 = rand.Next(1, 7); // Random number between 1 and 6
            int die2 = rand.Next(1, 7);
            Console.WriteLine($"Roll {i + 1}: Die 1 = {die1}, Die 2 = {die2}");
        }
    }
}