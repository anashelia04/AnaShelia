using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public static class MATH
    {
        public static double MyPow(double baseNumber, int power, out Status status)
        {

            if (power < 0)
            {
                status = Status.PowMustBePositiveOrZero;
                return 0;
            }
            status = Status.Success;
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= baseNumber;
            }

            return result;
        }

        public static int MyMin(int num1, int num2, out Status status)
        {
            int min;
            if (num1 < 0 && num2 < 0)
            {
                status = Status.PowMustBePositiveOrZero;
                return 0;
            }
            else if (num1 == num2)
            {
                status = Status.Success;
                return num1;
            }
            else if (num1 < num2)
            {
                min = num1;
                status = Status.Success;
                return min;
            }
            else
            {
                status = Status.Success;
                min = num2;
                return min;
            }
        }
        public static int MyMax(int num1, int num2, out Status status)
        {
            int max;
            if (num1 < 0 && num2 < 0)
            {
                status = Status.PowMustBePositiveOrZero;
                return 0;
            }
            else if (num1 == num2)
            {
                status = Status.Success;
                return num1;
            }
            else if (num1 > num2)
            {
                max = num1;
                status = Status.Success;
                return max;
            }
            else
            {
                status = Status.Success;
                max = num2;
                return max;
            }

        }

        //tuples

        public static Tuple<double, Status> MyPowTuple(double baseNumber, int power)
        {

            if (power < 0)
            {
                return new Tuple<double, Status>(0.0, Status.PowMustBePositiveOrZero);
            }
            Status status = Status.Success;
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= baseNumber;
            }

            return new Tuple<double, Status>(result, status);
        }

        public static Tuple<int, Status> MyMinTuple(int num1, int num2)
        {
            int min;
            if (num1 < 0 && num2 < 0)
            {
                return new Tuple<int, Status>(0, Status.PowMustBePositiveOrZero) ;
            }
            else if (num1 == num2)
            {
                return new Tuple<int, Status>(num1, Status.Success);
            }
            else if (num1 < num2)
            {
                min = num1;
                return new Tuple<int, Status>(min, Status.Success);
            }
            else
            {
                min = num2;
                return new Tuple<int, Status>(min, Status.Success);
            }
        }

        public static Tuple<int, Status> MyMaxTuple(int num1, int num2)
        {
            int max;
            if (num1 < 0 && num2 < 0)
            {
                return new Tuple<int, Status>(0, Status.PowMustBePositiveOrZero);
            }
            else if (num1 == num2)
            {
                return new Tuple<int, Status>(num1, Status.Success);
            }
            else if (num1 > num2)
            {
                max = num1;
                return new Tuple<int, Status>(max, Status.Success);
            }
            else
            {
                max = num2;
                return new Tuple<int, Status>(max, Status.Success);
            }

        }

    }

}
