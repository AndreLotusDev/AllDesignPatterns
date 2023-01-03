namespace AbstractFactory.Classes
{
    public abstract class Command
    {
        public Command(string query)
        {
            Query = query;
        }

        public string Query { get; set; } = "";
        public abstract string BringResult();
    }
}
