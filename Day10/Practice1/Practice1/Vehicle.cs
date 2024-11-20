using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public int Speed { get; set; }
        public int NumOfWheels { get; set; }
        public int PassengerCapacity { get; set; }
        public void Start()
        {
            Console.WriteLine("The engine is starting");
        }
        public void Stop()
        {
            Console.WriteLine("The vehicle is stopping");
        }
        public void Move()
        {
            Console.WriteLine("The vehicle is moving");
        }



    }
}