using AbstractFactory.Factories;
using System.Reflection;

namespace AbstractFactory.Classes
{
    public class ConnectionPool
    {
        public Connection GetConnection(string connectionType)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            Type exactTypeOfConnectionFactory = typeof(Type);
            bool found = false;

            foreach (var type in types)
            {
                if(type.IsAssignableTo(typeof(IConnectionFactory)) && type.FullName.ToUpper().Trim().Contains(connectionType.ToUpper()))
                {
                    exactTypeOfConnectionFactory = type;
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                throw new Exception("Not found any connection of this type");
            }

            var connection = ((IConnectionFactory?)Activator.CreateInstance(exactTypeOfConnectionFactory))?.GetConnection();

            if(connection == null)
            {
                throw new Exception("Wasnt possible to generate a connection");
            }

            return connection;
        }
    }
}
