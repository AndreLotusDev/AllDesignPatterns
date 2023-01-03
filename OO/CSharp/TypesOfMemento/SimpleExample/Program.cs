using TypesOfMemento.Classes;

var account = new BankAccount(1_000, "Andre Soares Gomes");

account.Deposit(2_000);
account.Deposit(3_000);

Console.WriteLine("The account balance now is " + account.Amount);

account.RevertToInitialValueInTheStart();

Console.WriteLine("The account balance now is after reverting everything again " + account.Amount);