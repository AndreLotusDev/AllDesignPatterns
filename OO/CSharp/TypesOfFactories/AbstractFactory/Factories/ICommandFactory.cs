using AbstractFactory.Classes;

namespace AbstractFactory.Factories
{
    public interface ICommandFactory
    {
        public Command GetCommand(string query);
    }
}
