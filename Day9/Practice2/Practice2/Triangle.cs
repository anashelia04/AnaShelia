using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Triangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        private double side3;
        public double Side3
        {
            get { return side3; }
            set
            {
                if (IsValidTriangle(Side1, Side2, value))
                {
                    side3 = value;
                }
                else
                {
                    throw new Exception("It is not valid triangle");
                }
            }
        }

        private bool IsValidTriangle(double side1, double side2, double side3)
        {
            return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
        }

        public double Area()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

    }
}
