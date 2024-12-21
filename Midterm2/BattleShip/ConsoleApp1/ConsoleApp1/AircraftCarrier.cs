using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier(Position position, string name) : base(position)
        {
            Type = ShipType.AircraftCarrier;
        }

        public AircraftCarrier(string name) : base(name) { }

        public void PlaceShip(string input)
        {
            
        }
    }
}
