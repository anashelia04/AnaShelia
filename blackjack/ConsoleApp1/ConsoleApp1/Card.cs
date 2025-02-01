using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Card
    {
        public string Color { get; }
        public string Value { get; }

        public Card(string color, string value)
        {
            Color = color;
            Value = value;
        }
       
    }
}
