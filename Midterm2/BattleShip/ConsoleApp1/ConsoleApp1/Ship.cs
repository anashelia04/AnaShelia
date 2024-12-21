using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Ship
    {
        public Position Position { get; set; } = position;
        public ShipType Type { get; protected init; }
        private string name;
        public string Name { get { return name; } }
        
        public Ship(string name)
        { 
            this.name = name;
        }

       
    }


    
}
