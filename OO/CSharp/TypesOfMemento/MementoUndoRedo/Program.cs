using MementoUndoRedo.Classes;

var account = new BankAccount(1_000, "Andre Soares Gomes");

account.Deposit(2_000);
account.Deposit(3_000);

account.GenerateANewMemento();

Console.WriteLine("The account balance now is " + account.Amount);

Console.WriteLine("================================================");

account.MoveBack();
account.MoveBack();
account.MoveBack(); 

Console.WriteLine("The account balance now is after reverting one time " + account.Amount);

account.MoveNext();
account.MoveNext();

Console.WriteLine("The account balance now is after undo the reverting " + account.Amount);

Console.WriteLine("================================================");

foreach (var history in account.BankHistoryHandler.History)
{
    Console.WriteLine($"Previous value {history.PreviousAmount} | Created At: {history.CreatedAt}");
}