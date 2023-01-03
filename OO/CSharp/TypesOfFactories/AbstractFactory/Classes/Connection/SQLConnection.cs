namespace AbstractFactory.Classes
{
    public class SQLConnection : Connection
    {
        public override void AddCommand(Command command)
        {
            commandsToExecute.Add(command);
        }
    }
}
