using static System.Console;
using static MathematicalInterpreter.Classes.OperationController;

var input = "(13+4)-(12+8)";
var tokens = LexToGenerateTokens(input);
WriteLine(string.Join("\t", tokens));

var parsed = Parse(tokens.ToList());
WriteLine($"{input} = {parsed.Value}");