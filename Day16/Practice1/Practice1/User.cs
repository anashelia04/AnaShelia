using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class User
    {
        public string Name { get; private set; }
        public IBAN Account { get; private set; }

        public User(string name, IBAN account)
        {
            Name = name;
            Account = account;
        }
    }
}
