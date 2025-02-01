using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dealer : Player
    {
        public void ShowHand()
        {
            Console.WriteLine("Dealer's hand: " + Hand);
        }
    }
}
