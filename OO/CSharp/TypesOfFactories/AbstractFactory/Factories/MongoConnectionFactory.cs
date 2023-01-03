using AbstractFactory.Classes;

namespace AbstractFactory.Factories
{
    public class MongoConnectionFactory : IConnectionFactory
    {
        public Connection GetConnection()
        {
            //Complex stuff here

            return new MongoConnection();
        }
    }
}
