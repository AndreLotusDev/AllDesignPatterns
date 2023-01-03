using SimpleDecorator.Classes;

Square square = new Square();   
var redSquare = new ColoredShape(square, "red");
var redSquareSemiTransparent = new TransparentShape(redSquare, 32);

Console.WriteLine(redSquareSemiTransparent.AsString());