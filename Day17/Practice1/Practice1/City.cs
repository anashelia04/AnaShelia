using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class City : GeographicEntity
    {

        public string CountryName;

        public bool IsCapital;
        public City(string name, double area, int population, bool isCapital, string countryName)
        {
            Name = name;
            Area = area;
            Population = population;
            CountryName = countryName;
            IsCapital = isCapital;
        }

        public override string ToString()
        {
            string capitalStatus = IsCapital ? "(Capital)" : "";
            return $"City: {Name}\nArea: {Area} \nPopulation: {Population} \nCapital: {IsCapital} \nCountry: {CountryName}";
        }
    }

}

