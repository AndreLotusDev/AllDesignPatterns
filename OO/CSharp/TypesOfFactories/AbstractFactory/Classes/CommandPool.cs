using AbstractFactory.Factories;
using System.Reflection;

namespace AbstractFactory.Classes
{
    public class CommandPool
    {
        private readonly string _type;
        public CommandPool(string type)
        {
            _type = type;
        }
        public Command GenerateCommand(string query)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            Type exactTypeOfCommandFactory = typeof(Type);
            bool found = false;

            foreach (var type in types)
            {
                if (type.IsAssignableTo(typeof(ICommandFactory)) && type.FullName.ToUpper().Trim().Contains(_type.ToUpper()))
                {
                    exactTypeOfCommandFactory = type;
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                throw new Exception("Not found any command of this type");
            }

            var command = ((ICommandFactory?)Activator.CreateInstance(exactTypeOfCommandFactory))?.GetCommand(query);

            if (command == null)
            {
                throw new Exception("Wasnt possible to generate a command");
            }

            return command;
        }
    }
}
