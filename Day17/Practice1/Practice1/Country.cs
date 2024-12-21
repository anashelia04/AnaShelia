using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Country : GeographicEntity
    {
        public List<City> Cities { get; set; }

        public Country(string name, List<City> cities)
        {
            Name = name;
            Cities = cities;
            foreach (City city in Cities)
            {
                Area += city.Area;
            }
            foreach (City city in Cities)
            {
                Population += city.Population;
            }
        }

        public override double Area
        {
            get
            {
                double totalArea = 0;
                foreach (City city in Cities)
                {
                    totalArea += city.Area;
                }

                return totalArea;
            }
        }

        public override int Population
        {
            get
            {
                int totalPopulation = 0;
                foreach (City city in Cities)
                {
                    totalPopulation += city.Population;
                }

                return totalPopulation;
            }
        }


        public override string ToString()
        {
            string result = $"Country: {Name}\nArea: {Area} \nPopulation: {Population}\nCities:";

            foreach (City city in Cities)
            {

                if (city.CountryName == Name)
                {
                    result += $"{city.Name},{(city.IsCapital ? "(isCapital)" : "")}\n";
                }
            }

            return result;
        }
    }
}

