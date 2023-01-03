using static System.Console;
using static BaseExampleFromCourse.Classes.DemoHandler;

var input = "(13+4)-(12+1)";
var tokens = Lex(input);
WriteLine(string.Join("\t", tokens));

var parsed = Parse(tokens);
WriteLine($"{input} = {parsed.Value}");