namespace MementoUndoRedo.Classes;

public class BankAccount
{
    public decimal Amount { get; set; }
    public string Name { get; set; }
    public BankHistoryHandler BankHistoryHandler { get; } = new();

    public BankAccount(decimal amount, string name)
    {
        Amount = amount;
        Name = name;
        
        BankHistoryHandler.AddHistory(new BankAccountMemento(amount));
    }

    public void Deposit(int amount)
    {
        //To implement status
        if (true)
        {
            BankHistoryHandler.AddHistory(new BankAccountMemento(amount));
            Amount += amount;    
        }
    }

    public void GenerateANewMemento()
    {
        BankHistoryHandler.AddHistory(new BankAccountMemento(Amount));
    }

    public void RevertToInitialValueInTheStart()
    {
        Amount = BankHistoryHandler.GetTheOldestOne().PreviousAmount;
    }

    public void MoveBack()
    {
        Amount = BankHistoryHandler.MoveBack().PreviousAmount;
    }

    public void MoveNext()
    {
        Amount = BankHistoryHandler.MoveNext().PreviousAmount;
    }
}