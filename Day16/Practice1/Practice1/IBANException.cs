using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class IBANException : Exception
    {
        public IBANException(string message) : base(message) { }
    }


}
