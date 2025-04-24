
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Trading Card Game!");

        int playerHealth = 100;
        int opponentHealth = 100;
        Random random = new Random();

        while (playerHealth > 0 && opponentHealth > 0)
        {
            Console.WriteLine($"Player Health: {playerHealth} | Opponent Health: {opponentHealth}");
            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                int playerAttack = random.Next(10, 20);
                opponentHealth -= playerAttack;
                int opponentAttack = random.Next(5, 15);
                playerHealth -= opponentAttack;
                Console.WriteLine($"Player attacks with {playerAttack} damage!");
                Console.WriteLine($"Opponent attacks with {opponentAttack} damage!");
            }
            else if(choice == 2)
            {
                int opponentAttack = random.Next(5, 15);
                playerHealth -= opponentAttack / 2;
                Console.WriteLine($"Player defends against {opponentAttack / 2} damage!");
                Console.WriteLine($"Opponent attacks with {opponentAttack} damage!");
            }

            if(playerHealth <= 0)
            {
                Console.WriteLine("You lose! Game over.");
            }
            else if(opponentHealth <= 0)
            {
                Console.WriteLine("Congratulations! You win!");
            }
        }
    }
}
