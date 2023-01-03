using System.Text;
using ReflectiveVisitor.Classes;

var operation = new AdditionExpression(new DoubleValueExpression(1), new AdditionExpression(new DoubleValueExpression(2), new DoubleValueExpression(3)));

var sb = new StringBuilder();
ExpressionPrinter.Print(operation, sb);