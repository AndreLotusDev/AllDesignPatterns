using AbstractFactory.Classes;

namespace AbstractFactory.Factories
{
    public class MongoCommandFactory : ICommandFactory
    {
        public Command GetCommand(string query)
        {
            return new MongoCommand(query);
        }
    }
}
