namespace CompositeCommand.Classes
{
    public class MoneyTransferCommand : CompositeBankCommand
    {
        public MoneyTransferCommand(BankAccount from, BankAccount to, double quantity)
        {
            AddRange(new []
            {
                new Command(from, quantity, Command.EAction.WITHDRAWN),
                new Command(to, quantity, Command.EAction.DEPOSIT),
            });
        }
        public override void Execute()
        {
            bool isOk = true;

            ForEach(cmd =>
            {
                if (isOk)
                {
                    cmd.Execute();
                }
                isOk = cmd.Success;
                if (isOk is false)
                {
                    isOk = false;
                }
            });
        }
    }
}
