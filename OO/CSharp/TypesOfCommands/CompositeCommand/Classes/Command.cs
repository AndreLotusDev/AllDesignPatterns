namespace CompositeCommand.Classes
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
                Success = false;
            }

        }

        public void Undo()
        {
            if (action == EAction.DEPOSIT && Success)
            {
                _bankAccount.WithDraw(amount);
            }
            if (action == EAction.WITHDRAWN && Success)
            {
                _bankAccount.Deposit(amount);
            }
        }

        public bool Success { get; set; } = true;
    }
}
