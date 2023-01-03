using AbstractFactory.Classes;

namespace AbstractFactory.Factories
{
    public class SQLCommandFactory : ICommandFactory
    {
        public Command GetCommand(string query)
        {
            return new SQLCommand(query);
        }
    }
}
