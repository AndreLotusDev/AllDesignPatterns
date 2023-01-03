using SimpleNullPatern.Classes;

var log = Null<ILog>.Instance;
var ba = new BankAccount(log);

ba.Deposit(100);
ba.Withdraw(100);

ba.DisplayQuantity();