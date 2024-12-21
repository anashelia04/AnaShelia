using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    public class Public : Vehicle
    {
        public Public(int id, int speed, int numOfWheels, int passengerCapacity)
        {
            Id = id;
            Speed = speed;
            NumOfWheels = numOfWheels;
            PassengerCapacity = passengerCapacity;
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Number of wheels: " + numOfWheels);
            Console.WriteLine("Passenger capacity: " + passengerCapacity);
        }

        public void Signal()
        {
            Console.WriteLine("The public vehicle is signaling");
        }
        public void OpenDoors()
        {
            Console.WriteLine("The doors of the public transport are being opened");
        }
        public void CloseDoors()
        {
            Console.WriteLine("The doors of the public transport are being closed");
        }
        
    }
}

