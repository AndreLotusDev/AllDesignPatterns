namespace AbstractFactory.Classes
{
    public abstract class Connection
    {
        public Connection()
        {
            ConnectionId = Guid.NewGuid();
        }
        public Guid ConnectionId { get; set; }
        public List<Command> commandsToExecute = new List<Command>();

        public abstract void AddCommand(Command command);
    }
}
