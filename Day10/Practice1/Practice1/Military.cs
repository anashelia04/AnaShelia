using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    public class Military : Vehicle
    {
        public Military(int id, int speed, int numOfWheels, int passengerCapacity)
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

        public void Attack()
        {
            Console.WriteLine("The military vehicle is attacking");
        }

    }
}