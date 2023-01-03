namespace HouseCommands.cs.Classes
{
    public class SmartLightCompositeCommandController : List<CommandBase>
    {
        public SmartLightCompositeCommandController(CommandBase[] commands)
        {
            AddRange(commands);
        }

        public void ExecuteAll()
        {
            ForEach(cmd => cmd.Execute());
        }

        public void UndoAll()
        {
            ForEach(cmd => cmd.Undo());
        }
    }
}
