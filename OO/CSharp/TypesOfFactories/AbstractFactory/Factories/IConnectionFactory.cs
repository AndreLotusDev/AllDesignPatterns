using AbstractFactory.Classes;

namespace AbstractFactory.Factories
{
    public interface IConnectionFactory
    {
        public Connection GetConnection();
    }
}
