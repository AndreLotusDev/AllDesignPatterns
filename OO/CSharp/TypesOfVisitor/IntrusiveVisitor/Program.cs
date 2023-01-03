using System.Text;
using IntrusiveVisitor.Classes;

var operation = new AdditionExpression(new DoubleValueExpression(1), new AdditionExpression(new DoubleValueExpression(2), new DoubleValueExpression(3)));

var sb = new StringBuilder();
operation.Print(sb);
Console.WriteLine(sb.ToString());