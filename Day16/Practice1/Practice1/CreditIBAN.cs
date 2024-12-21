using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class CreditIBAN : IBAN
    {
        public decimal CreditLimit { get; private set; }

        public CreditIBAN(string accountNumber, decimal initialBalance, decimal creditLimit) : base(accountNumber, initialBalance)
        {
            CreditLimit = creditLimit;
        }

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

            if (Balance - amount < -CreditLimit)
                throw new AmountException("Withdrawal exceeds the credit limit.");

            Balance -= amount;
        }
    }
}
