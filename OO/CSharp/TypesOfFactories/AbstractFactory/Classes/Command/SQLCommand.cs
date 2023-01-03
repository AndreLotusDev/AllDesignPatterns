namespace AbstractFactory.Classes
{
    public class SQLCommand : Command
    {
        public SQLCommand(string query) : base(query)
        {
        }

        public override string BringResult()
        {
            return $"SQL COMMAND: {Query}";
        }
    }
}
