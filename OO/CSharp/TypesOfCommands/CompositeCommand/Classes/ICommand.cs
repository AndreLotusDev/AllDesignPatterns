namespace CompositeCommand.Classes
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        public bool Success { get; set; }
    }
}
