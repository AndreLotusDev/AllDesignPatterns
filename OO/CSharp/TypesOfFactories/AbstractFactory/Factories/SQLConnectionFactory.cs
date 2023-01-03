using AbstractFactory.Classes;

namespace AbstractFactory.Factories
{
    public class SQLConnectionFactory : IConnectionFactory
    {
        public Connection GetConnection()
        {
            //Complex stuff here

            return new SQLConnection();
        }
    }
}
