namespace SimpleExample.Classes
{
    public class CustomerData
    {
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }

        public CustomerData()
        {
            
        }
        public CustomerData(string name, string address, int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }
}
