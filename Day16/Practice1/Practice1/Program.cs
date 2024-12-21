using Practice1;

try
{
    CreditIBAN creditAccount = new CreditIBAN("CREDIT123", 1000, 500);
    DebitIBAN debitAccount = new DebitIBAN("DEBIT123", 1000);

    User creditUser = new User("Ana", creditAccount);
    User debitUser = new User("Eka", debitAccount);

    Console.WriteLine("Depositing 200 into Ana's Credit Account...");
    creditUser.Account.Deposit(200);
    Console.WriteLine("New Balance: " + creditUser.Account.Balance);

    Console.WriteLine("Withdrawing 300 from Eka's Debit Account...");
    debitUser.Account.Withdraw(300);
    Console.WriteLine("New Balance: " + debitUser.Account.Balance);

    Console.WriteLine("Withdrawing 2000 from Eka's Debit Account...");
    debitUser.Account.Withdraw(2000);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ExceptionHandling.GetLastInnerExMessage(ex));
    Console.WriteLine("Full error: " + ExceptionHandling.GetAllInnerExMessageTogether(ex));
}