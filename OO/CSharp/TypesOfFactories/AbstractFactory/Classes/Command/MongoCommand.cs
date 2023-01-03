namespace AbstractFactory.Classes
{
    public class MongoCommand : Command
    {
        public MongoCommand(string query) : base(query)
        {
        }

        public override string BringResult()
        {
            return $"MONGO COMMAND: {Query}";
        }
    }
}
