namespace AbstractFactory.Classes
{
    public class MongoConnection : Connection
    {
        public override void AddCommand(Command command)
        {
            commandsToExecute.Add(command);
        }
    }
}
