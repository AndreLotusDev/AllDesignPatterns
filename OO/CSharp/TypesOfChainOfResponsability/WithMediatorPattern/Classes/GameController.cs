namespace WithMediatorPattern.Classes;

public class GameController
{
    public EventHandler<QuerySoldier> queries;

    public void ExecuteQueries(object sender, QuerySoldier query)
    {
        queries?.Invoke(sender, query);
    }
}