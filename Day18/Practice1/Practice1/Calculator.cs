using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Division by zero is not allowed.");
            return a / b;
        }

        public double Power(double baseNumber, int exponent)
        {
            double result = 1;
            bool isNegativeExponent = exponent < 0;
            exponent = Math.Abs(exponent);

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            if (isNegativeExponent)
            {
                return 1 / result;
            }
            else
            {
                return result;
            }
        }
    }
}
