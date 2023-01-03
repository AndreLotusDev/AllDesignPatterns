namespace MementoUndoRedo.Classes;

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
    public BankAccountMemento CurrentHistory { get; set; }

    public void AddHistory(BankAccountMemento history)
    {
        History.Add(history);
        CurrentHistory = history;
    }

    public BankAccountMemento MoveBack()
    {
        var position = History.IndexOf(CurrentHistory);

        if (position - 1 >= 0)
        {
            CurrentHistory = History[position - 1];
            return CurrentHistory;
        }

        return null;
    }

    public BankAccountMemento MoveNext()
    {
        var position = History.IndexOf(CurrentHistory);

        if (position + 1 < History.Count)
        {
            CurrentHistory = History[position + 1];
            return CurrentHistory;
        }
        
        return null;
    }

    public BankAccountMemento GetTheOldestOne()
    {
        CurrentHistory = History
            .OrderBy(o => o.CreatedAt)
            .FirstOrDefault();

        return CurrentHistory;
    }

    public BankAccountMemento PickTheFirstOneOfTheDay()
    {
        CurrentHistory = History
            .Where(w => w.CreatedAt.Date == DateTime.Now.Date)
            .OrderBy(d => d.CreatedAt).First();

        return CurrentHistory;
    }
}