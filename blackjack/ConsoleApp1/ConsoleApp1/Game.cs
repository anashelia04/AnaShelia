using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        private Deck deck;
        private Dealer dealer;
        private List<Player> players;

        public Game(int playerCount)
        {
            deck = new Deck();
            dealer = new Dealer();
            players = new List<Player>();

            for (int i = 0; i < playerCount; i++)
            {
                players.Add(new Player());
            }
        }

        public void Play()
        {
            deck.Shuffle();

            foreach (var player in players)
            {
                player.AddCard(deck);
                player.AddCard(deck);

                Console.WriteLine(player.Name + "'s hand: " + player.Hand + " - Total: " + player.CalculateHandValue());
            }

            dealer.AddCard(deck);
            dealer.AddCard(deck);
            Console.WriteLine(dealer.Name + "'s hand: " + dealer.Hand + " - Total: " + dealer.CalculateHandValue());

            foreach (var player in players)
            {
                
            }

        }

        private void PlayerTurn(Player player)
        {
            while (player.CalculateHandValue() < 21)
            {
                Console.WriteLine(player.Name + " if you want to continue choose c, otherwise choose n");
                string choice = Console.ReadLine().ToLower();
                if (choice == "c")
                {
                    player.AddCard(deck);

                    Console.WriteLine(player.Name + "'s hand: " + player.Hand);
                }
                else
                {
                    break;
                }
            }
        }

        private void DealerTurn()
        {
            dealer.AddCard(deck);
        }

        private void Winner()
        {
            int dealerValue = dealer.CalculateHandValue();

            Console.WriteLine("Dealers final hand value " + dealer.Hand);

            foreach (var player in players)
            {
                int playerValue = player.CalculateHandValue();
                Console.WriteLine(player.Name + "'s final hand value " + player.Hand);

                if(playerValue == dealerValue)
                {
                    Console.WriteLine("tie");
                }
                else if(playerValue > dealerValue)
                {
                    Console.WriteLine(player.Name + " wins");
                }
            }
        }


    }
}
