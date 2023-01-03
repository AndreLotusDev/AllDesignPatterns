namespace HouseCommands.cs.Classes
{
    public class SmartLightDictionaryController
    {
        public Dictionary<string, List<CommandBase>> CommandsPerLight { get; private set; }

        public SmartLightDictionaryController()
        {
            CommandsPerLight = new();
        }

        public void ConfigureCommandPerLight(string key, List<CommandBase> commands)
        {
            var alreadyExist = CommandsPerLight.ContainsKey(key);

            if (alreadyExist)
            {
                CommandsPerLight[key].AddRange(commands);
            }
            else
            {
                CommandsPerLight.Add(key, commands);
            }
        }

        public void ExecuteAll(string key)
        {
            try
            { 
                CommandsPerLight[key].ForEach(cmd => cmd.Execute());
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error while executing functions:" + e);
            }
        }

        public void UndoAll(string key)
        {
            try
            {
                CommandsPerLight[key].ForEach(cmd => cmd.Undo());
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error while undoing functions:" + e);
            }
        }
    }
}
