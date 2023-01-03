using SingletonNullPatern.Classes;

var ba = new BankAccount(ILog.NullLog.Instance);

ba.Deposit(100);
ba.Withdraw(100);

ba.DisplayQuantity();