namespace SimpleExample.Classes
{
    public class BankAccount
    {
        public BankAccount(double quantityInBank, string bankAccountName)
        {
            QuantityInBank = quantityInBank;
            BankAccountName = bankAccountName;
        }

        public double QuantityInBank { get; set; }
        public string BankAccountName { get; set; }
        private const double OVERDRAFT_LIMIT = 500;

        public void Deposit(double quantity)
        {
            QuantityInBank += quantity;
        }

        public void WithDraw(double quantity)
        {
            if (QuantityInBank - quantity <= -OVERDRAFT_LIMIT)
            {
                throw new ArgumentException("Can't complete this withdraw");
            }

            QuantityInBank -= quantity;
        }

        public void DisplayQuantityInBank()
        {
            Console.WriteLine($"The user {BankAccountName} have in bank {QuantityInBank} $");
        }
    }
}
