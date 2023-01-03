namespace SingletonNullPatern.Classes;

public class BankAccount
{
    private readonly ILog _log;

    public BankAccount(ILog log)
    {
        _log = log;
    }
    public int Quantity { get; set; }
    
    public void Deposit(int amount)
    {
        Quantity += amount;
        _log.Warn("BankAccount: Deposit of " + amount + " made. New balance is " + Quantity);
    }
    
    public void Withdraw(int amount)
    {
        Quantity -= amount;
        _log.Warn("Withdrawn " + amount + " from account");
    }
    
    public void DisplayQuantity()
    {
        Console.WriteLine("Quantity: {0}", Quantity);
    }
}