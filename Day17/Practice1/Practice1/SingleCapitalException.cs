using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class SingleCapitalException : Exception
    {
        public SingleCapitalException(string message) : base(message)
        {
            Console.WriteLine("The country must have only one capital");
        }
    }
}

