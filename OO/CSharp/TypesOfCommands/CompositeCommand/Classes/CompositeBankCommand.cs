namespace CompositeCommand.Classes
{
    public class CompositeBankCommand : List<Command>, ICommand
    {
        public virtual void Execute()
        {
            ForEach(cmd => cmd.Execute());
        }

        public virtual void Undo()
        {
            foreach (var command in ((IEnumerable<Command>)this).Reverse())
            {
                command.Undo();
            }
        }

        public bool Success
        {
            get
            {
                return TrueForAll(cmd => cmd.Success == true);
            }
            set
            {

            }
        } 
    }
}
