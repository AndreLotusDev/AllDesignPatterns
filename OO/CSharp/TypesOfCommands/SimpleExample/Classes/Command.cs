namespace SimpleExample.Classes
{
    public class Command : ICommand
    {
        public Command(BankAccount bankAccount, double amount, EAction action)
        {
            _bankAccount = bankAccount;
            this.amount = amount;
            this.action = action;
        }

        private BankAccount _bankAccount;
        public double amount;
        public bool succeded = true;
        public EAction action;

        public enum EAction
        {
            WITHDRAWN,
            DEPOSIT
        }

        public void Execute()
        {
            try
            {
                switch (action)
                {
                    case EAction.DEPOSIT:
                        _bankAccount.Deposit(amount);
                        break;
                    case EAction.WITHDRAWN:
                        _bankAccount.WithDraw(amount);
                        break;
                }
            }
            catch (Exception e)
            {
                succeded = false;
            }
            
        }

        public void Undo()
        {
            if (action == EAction.DEPOSIT && succeded)
            {
                _bankAccount.WithDraw(amount);
            }
            if (action == EAction.WITHDRAWN && succeded)
            {
                _bankAccount.Deposit(amount);
            }
        }
    }
}
