using static System.Console;

using WithMediatorPattern.Classes;

var gc = new GameController();
var soldier = new Soldier(gc, "Soldier One", 10, 20);

using(var modifier = new IncreaseSpeedModifier(gc, soldier))
    using(var attackModifier = new FortifyAttackModifier(gc, soldier))
        using(var anotherSpeedModifier = new IncreaseSpeedModifier(gc, soldier))
            WriteLine(soldier);

