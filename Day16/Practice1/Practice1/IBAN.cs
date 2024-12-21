using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public abstract class IBAN
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        protected IBAN(string accountNumber, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new IBANException("IBAN cannot be null or empty.");

            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
    }

}
