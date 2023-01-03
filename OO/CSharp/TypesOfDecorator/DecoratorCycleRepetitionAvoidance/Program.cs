using DecoratorCycleRepetitionAvoidance.Classes;

var square = new Square(2);
var colored3 = new ColoredShape(square, "orange");
var colored1 = new ColoredShape(colored3, "red");
var colored2 = new ColoredShape(colored1, "blue");
Console.WriteLine(colored2.AsString());
