using ClassicSimpleExample.Classes;

var soldier = new Soldier();
new AttackState().SetToAttackMode(soldier);
new DefenseState().SetToDefenseMode(soldier);
new DefenseState().SetToDefenseMode(soldier);