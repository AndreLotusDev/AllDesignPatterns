namespace SimpleExample.Classes
{
    public class SantanderBank
    {
        public double Amount { get; set; }
        private readonly string _name;

        public SantanderBank(double amount, string name)
        {
            Amount = amount;
            _name = name;
        }
        public static SantanderBank FactoryFakeAccount()
        {
            return new SantanderBank(10_000, "Silva");
        }

        public void DoAWithDraw(double amount)
        {
            var isPossible = amount < Amount;

            if (isPossible is false)
            {
                throw new Exception("Is not possible to do a withdraw with this value");
            }

            Amount -= amount;
            Console.WriteLine($"Withdraw of the value {amount} made with success!");
        }
    }
}
