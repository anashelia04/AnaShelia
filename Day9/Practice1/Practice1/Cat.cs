using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice1
{
    internal class Cat
    {
        public string Name { get; set; }
        private string breed;
        public string Breed
        {
            get => breed;
            set
            {
                breed = value;
            }
        }
        public int Age { get; set; }
        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private int bite = 10;

        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }

        public void Eat(int grams)
        {
            Console.WriteLine($"{Name} started eating.");
            int number = grams / bite;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Eating...");
            }
            Console.WriteLine($"{Name} finished eating.");
        }
    }
}
