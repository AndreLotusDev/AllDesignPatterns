namespace HouseCommands.cs.Classes
{
    public abstract class CommandBase
    {
        public bool AlreadyExecuted { get; private set; }
        public bool AlreadyUndo { get; private set; }

        private void _execute()
        {
            AlreadyExecuted = true;
        }

        private void _undo()
        {
            AlreadyUndo = true;
        }
        public virtual void Execute()
        {
            if (AlreadyExecuted)
            {
                throw new InvalidOperationException("This command already executed");  
            }

            _execute();
        }

        public virtual void Undo()
        {
            if (AlreadyUndo)
            {
                throw new InvalidOperationException("This command already was undo");
            }

            _undo();
        }
    }
}
