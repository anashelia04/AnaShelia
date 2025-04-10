using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
           cards = new List<Card>();
           random = new Random();

        }

        private void InitializeDeck()
        {
            string[] values = {"2", "3", "4", "5", "6", "7", "8", "9",  "10", "J", "K", "Q", "A"};
            string[] colors = { "aguri", "guli", "jvari", "yvavi" };

            foreach (string value in values) 
            {
                foreach (string color in colors)
                {
                    cards.Add(new Card(value, color));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = cards.Count - 1; i >= 0; i--)
            {
                int j = random.Next(i + 1);
                Card temporary = cards[i];
                cards[i] = cards[j];
                cards[j] = temporary;
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
