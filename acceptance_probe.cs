
using System;

namespace TradingCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Trading Card Game!");

            Console.WriteLine("Player 1, enter your name:");
            string player1Name = Console.ReadLine();
            Player player1 = new Player(player1Name);

            Console.WriteLine("Player 2, enter your name:");
            string player2Name = Console.ReadLine();
            Player player2 = new Player(player2Name);

            Deck deck = new Deck();
            deck.Shuffle();

            for (int i = 0; i < 5; i++)
            {
                player1.DrawCard(deck);
                player2.DrawCard(deck);
            }

            bool gameOver = false;
            Player currentPlayer = player1;

            while (!gameOver)
            {
                Console.WriteLine($"{currentPlayer.Name}'s turn");
                Console.WriteLine("1. Play card");
                Console.WriteLine("2. End turn");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Select a card to play:");
                    currentPlayer.DisplayHand();
                    int cardIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    currentPlayer.PlayCard(cardIndex);
                }
                else
                {
                    currentPlayer = currentPlayer == player1 ? player2 : player1;
                }

                if (player1.Hand.Count == 0 || player2.Hand.Count == 0)
                {
                    gameOver = true;
                }
            }

            Console.WriteLine("Game over!");

            if (player1.Hand.Count == 0)
            {
                Console.WriteLine($"{player2.Name} wins!");
            }
            else
            {
                Console.WriteLine($"{player1.Name} wins!");
            }
        }
    }

    class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public void DrawCard(Deck deck)
        {
            Card card = deck.DrawCard();
            Hand.Add(card);
        }

        public void PlayCard(int index)
        {
            Card card = Hand[index];
            Console.WriteLine($"{Name} played {card.Name}");
            Hand.RemoveAt(index);
        }

        public void DisplayHand()
        {
            for (int i = 0; i < Hand.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Hand[i].Name}");
            }
        }
    }

    class Card
    {
        public string Name { get; set; }

        public Card(string name)
        {
            Name = name;
        }
    }

    class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();

            cards.Add(new Card("Card1"));
            cards.Add(new Card("Card2"));
            cards.Add(new Card("Card3"));
            cards.Add(new Card("Card4"));
            cards.Add(new Card("Card5"));
        }

        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DrawCard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}
