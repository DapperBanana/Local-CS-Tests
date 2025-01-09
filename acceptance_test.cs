
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Job Application System");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your desired position: ");
        string position = Console.ReadLine();

        Console.Write("Please enter your years of experience: ");
        int experience = int.Parse(Console.ReadLine());

        if (experience >= 2)
        {
            Console.WriteLine("Congratulations, " + name + "! You have been selected for the position of " + position + ".");
        }
        else
        {
            Console.WriteLine("We regret to inform you that you do not have enough experience for the position of " + position + ".");
        }
    }
}
