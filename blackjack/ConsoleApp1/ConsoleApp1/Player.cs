using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        public string Name { get; }
        public List<Card> Hand { get; }

        public Player()
        {
            Hand = new List<Card>();
        }

        public void AddCard(Deck deck)
        {
            Card card = deck.DrawCard();
            Hand.Add(card);
        }

        public int CalculateHandValue()
        {
            int value = 0;

            foreach (Card card in Hand)
            {
                if (card.Value == "J" || card.Value == "K" || card.Value == "Q")
                {
                    value = value + 10;
                }
                else if (card.Value == "A")
                {
                    value = value + 11;
                }
                else 
                { 
                    value = value + int.Parse(card.Value);
                }
            }
            return value;
        }

        public void ShowHand()
        {
            Console.WriteLine("Your hand " + Hand);
        }


    }
}
