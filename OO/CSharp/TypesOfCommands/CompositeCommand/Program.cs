using CompositeCommand.Classes;

var bankAccountAndre = new BankAccount(0, "Andre Soares Gomes");
var deposit = new Command(bankAccountAndre, 2_2000, Command.EAction.DEPOSIT);
deposit.Execute();

var bankAccountJose = new BankAccount(0, "Jose Soares Gomes");
var cmd = new MoneyTransferCommand(bankAccountAndre, bankAccountJose, 2_000);

bankAccountAndre.DisplayQuantityInBank();
bankAccountJose.DisplayQuantityInBank();
cmd.Execute();
bankAccountAndre.DisplayQuantityInBank();
bankAccountJose.DisplayQuantityInBank();
cmd.Undo();
bankAccountAndre.DisplayQuantityInBank();
bankAccountJose.DisplayQuantityInBank();
