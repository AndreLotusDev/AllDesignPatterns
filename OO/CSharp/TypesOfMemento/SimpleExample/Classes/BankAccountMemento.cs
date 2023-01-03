namespace TypesOfMemento.Classes;

public class BankAccountMemento
{
    public decimal PreviousAmount { get; set; }
    public DateTime CreatedAt { get; set; }

    public BankAccountMemento(decimal previousAmount)
    {
        PreviousAmount = previousAmount;
        CreatedAt = DateTime.Now;
    }
}

public class BankHistoryHandler
{
    public List<BankAccountMemento> History { get; set; } = new();

    public void AddHistory(BankAccountMemento history)
    {
        History.Add(history);
    }

    public BankAccountMemento GetTheOldestOne()
    {
        return History
            .OrderBy(o => o.CreatedAt)
            .FirstOrDefault();
    }

    public BankAccountMemento PickTheFirstOneOfTheDay()
    {
        return History
            .Where(w => w.CreatedAt.Date == DateTime.Now.Date)
            .OrderBy(d => d.CreatedAt).First();
    }
}