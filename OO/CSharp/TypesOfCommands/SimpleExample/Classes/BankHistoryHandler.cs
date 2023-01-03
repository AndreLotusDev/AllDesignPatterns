namespace SimpleExample.Classes
{
    public class BankHistoryHandler
    {
        public List<ICommand> commands;

        public BankHistoryHandler()
        {
            commands = new List<ICommand>();
        }

        public void Add(ICommand command)
        {
            commands.Add(command);
        }

        public void UndoAll()
        {
            commands.Reverse();
            foreach (var command in commands)
            {
                command.Undo();
            }
        }
    }
}
