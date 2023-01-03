using LoggingProxy.Classes;

var ba = LoggingHelper<BankAccount>.As<IBankAccount>();
ba.Deposit(2500);
ba.Deposit(2500);
ba.Deposit(2500);

Console.WriteLine(ba.ToString());

ba.Withdraw(2500);

Console.WriteLine(ba.ToString());

Console.WriteLine(ba.ToString());