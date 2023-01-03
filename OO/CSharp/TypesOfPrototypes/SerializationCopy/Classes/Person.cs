using SerializationCopy.Interfaces;

namespace SerializationCopy.Classes
{
    public class Person 
    {
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public int Age { get; set; }
        public Address Address { get; set; } = new Address();
        public Person()
        {

        }
        public Person(string name, string surName, int age, Address address)
        {
            Name = name;
            Surname = surName;
            Age = age;
            Address = address;
        }

        public override string ToString()
        {
            return $"Nome {Name}, Sobrenome {Surname}, Idade {Age}, Endereco -> {Address.ToString()}";
        }
    }
}
