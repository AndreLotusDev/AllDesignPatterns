using SerializationCopy.Interfaces;

namespace SerializationCopy.Classes
{
    public class Address
    {
        public Address()
        {

        }

        public Address(string firstAddress, string secondAddress)
        {
            MainAddress = firstAddress;
            SecondAddress = secondAddress;
        }

        public string MainAddress { get; set; } = "";
        public string SecondAddress { get; set; } = "";

        public override string ToString()
        {
            return $"Endereco Primario {MainAddress}, EnderecoSegundario {SecondAddress}";
        }
    }
}
