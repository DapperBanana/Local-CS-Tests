
using System;

namespace TextBasedTradingCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Text-Based Trading Card Game!");

            // Create player 1
            Player player1 = new Player("Player 1");
            player1.AddCard(new Card("Warrior", 10, 5));
            player1.AddCard(new Card("Mage", 5, 10));
            player1.AddCard(new Card("Archer", 7, 7));

            // Create player 2
            Player player2 = new Player("Player 2");
            player2.AddCard(new Card("Dragon", 15, 8));
            player2.AddCard(new Card("Goblin", 3, 3));
            player2.AddCard(new Card("Wizard", 6, 12));

            // Start the game
            while (player1.HasCards() && player2.HasCards())
            {
                // Player 1's turn
                Console.WriteLine($"{player1.Name}'s turn:");
                player1.DisplayCards();
                Console.WriteLine("Choose a card to play (1-3):");
                int cardIndex = int.Parse(Console.ReadLine()) - 1;
                Card player1Card = player1.PlayCard(cardIndex);

                // Player 2's turn
                Console.WriteLine($"{player2.Name}'s turn:");
                player2.DisplayCards();
                Console.WriteLine("Choose a card to play (1-3):");
                cardIndex = int.Parse(Console.ReadLine()) - 1;
                Card player2Card = player2.PlayCard(cardIndex);

                // Resolve the battle
                Console.WriteLine($"Battle between {player1Card.Name} and {player2Card.Name}:");
                player1Card.Attack(player2Card);
                player2Card.Attack(player1Card);

                // Check for defeated cards
                if (player1Card.Health <= 0)
                {
                    Console.WriteLine($"{player1Card.Name} has been defeated!");
                }
                if (player2Card.Health <= 0)
                {
                    Console.WriteLine($"{player2Card.Name} has been defeated!");
                }

                // Add defeated cards to winner's deck
                if (player1Card.Health > 0)
                {
                    player1.AddCard(player1Card);
                }
                if (player2Card.Health > 0)
                {
                    player2.AddCard(player2Card);
                }
            }

            // Determine the winner
            if (player1.HasCards())
            {
                Console.WriteLine($"{player1.Name} wins!");
            }
            else
            {
                Console.WriteLine($"{player2.Name} wins!");
            }
        }
    }

    class Player
    {
        public string Name { get; }
        private List<Card> deck = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public void AddCard(Card card)
        {
            deck.Add(card);
        }

        public void DisplayCards()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {deck[i].Name} - Attack: {deck[i].Attack}, Health: {deck[i].Health}");
            }
        }

        public Card PlayCard(int index)
        {
            Card card = deck[index];
            deck.RemoveAt(index);
            return card;
        }

        public bool HasCards()
        {
            return deck.Count > 0;
        }
    }

    class Card
    {
        public string Name { get; }
        public int Attack { get; }
        public int Health { get; private set; }

        public Card(string name, int attack, int health)
        {
            Name = name;
            Attack = attack;
            Health = health;
        }

        public void Attack(Card opponent)
        {
            opponent.Health -= Attack;
        }
    }
}
