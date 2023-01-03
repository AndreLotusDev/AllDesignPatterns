using SimpleExample.Classes;

var bankAccount = new BankAccount(0, "Andre Soares Gomes");

var firstDeposit = new Command(bankAccount, 2_000, Command.EAction.DEPOSIT);
firstDeposit.Execute();

var secondDeposit = new Command(bankAccount, 2_000, Command.EAction.DEPOSIT);
secondDeposit.Execute();

var firstWithDraw = new Command(bankAccount, 1_000, Command.EAction.WITHDRAWN);
firstWithDraw.Execute();

var bankHistoryCommands = new BankHistoryHandler();
bankHistoryCommands.Add(firstDeposit);
bankHistoryCommands.Add(secondDeposit);
bankHistoryCommands.Add(firstWithDraw);

bankAccount.DisplayQuantityInBank();
bankHistoryCommands.UndoAll();
bankAccount.DisplayQuantityInBank();

