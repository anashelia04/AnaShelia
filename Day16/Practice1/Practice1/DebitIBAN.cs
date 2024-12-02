using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class DebitIBAN : IBAN
    {
        public DebitIBAN(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance) { }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new AmountException("Deposit amount must be greater than zero.");

            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new AmountException("Withdrawal amount must be greater than zero.");

            if (Balance - amount < 0)
                throw new AmountException("Insufficient balance.");

            Balance -= amount;
        }
    }

}
