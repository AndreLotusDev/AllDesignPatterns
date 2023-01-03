namespace SimpleExample.Classes
{
    public interface IBankFacade
    {
        public void WithDraw(double amount, string name);
    }

    public class BankHandler : IBankFacade
    {
        private readonly SantanderBank _santanderBank;
        private readonly SerasaHandler _serasaHandler;
        private readonly CadimHandler _cadimHandler;

        public BankHandler()
        {
            _santanderBank = SantanderBank.FactoryFakeAccount();
            _serasaHandler = new SerasaHandler();
            _cadimHandler = new CadimHandler();
        }
        public void WithDraw(double amount, string name)
        {
            _serasaHandler.IsInadiplent(name);
            _cadimHandler.IsInadiplent(name);
            _santanderBank.DoAWithDraw(amount);
        }
    }
}
