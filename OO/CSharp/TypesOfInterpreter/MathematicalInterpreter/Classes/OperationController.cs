using System.Text;

namespace MathematicalInterpreter.Classes;

public class OperationController
{
    public static IReadOnlyCollection<Token> LexToGenerateTokens(string toParse)
    {
        var bufferNumbers = new List<string>();
        var actualPosition = 0;
        var positionsCovered = new List<int>();
        List<Token> tokensToReturn = new();

        var inCharInput = toParse.ToCharArray();
        
        foreach (var toAnalyse in inCharInput)
        {
            if (positionsCovered.Any(a => a == toAnalyse))
            {
                continue;
            }
            
            var insidePosition = actualPosition;
            StringBuilder numberBuilder = new();
            
            if (char.IsDigit(toAnalyse))
            {
                bool shouldStop = false;
                positionsCovered.Add(actualPosition);

                insidePosition = actualPosition;
                while (insidePosition < inCharInput.Length && !shouldStop)
                {
                    var charAsNumberToAnalyse = inCharInput[insidePosition];
                    if (char.IsDigit(charAsNumberToAnalyse))
                    {
                        numberBuilder.Append(inCharInput[insidePosition]);
                    }
                    else
                    {
                        bufferNumbers.Add(numberBuilder.ToString());
                        shouldStop = true;
                    }

                    insidePosition++;
                    positionsCovered.Add(insidePosition);
                }
                
                tokensToReturn.Add(new Token()
                {
                    Type = EType.Number,
                    Text = bufferNumbers.Last(),
                });
            }

            actualPosition++;

            if (toAnalyse == '(')
            {
                tokensToReturn.Add(new Token()
                {
                    Type = EType.LeftParenthesis,
                    Text = toAnalyse.ToString()
                });
            }

            if (toAnalyse == ')')
            {
                tokensToReturn.Add(new Token()
                {
                    Type = EType.RightParenthesis,
                    Text = toAnalyse.ToString()
                });
            }
            
            if (toAnalyse == '+')
            {
                tokensToReturn.Add(new Token()
                {
                    Type = EType.Addiction,
                    Text = toAnalyse.ToString()
                });
            }
            
            if (toAnalyse == '-')
            {
                tokensToReturn.Add(new Token()
                {
                    Type = EType.Subtraction,
                    Text = toAnalyse.ToString()
                });
            }
            
            if (toAnalyse == '/')
            {
                throw new NotImplementedException("We don't support division operations");
            }
            
            if (toAnalyse == '*')
            {
                throw new NotImplementedException("We don't support multiplication operations");
            }
        }

        return tokensToReturn.AsReadOnly();
    }

    public static IntegerElement Parse(List<Token> tokens)
    {
        var result = new BinaryOperation();
        var toReturn = new IntegerElement();
        var leftSideResolved = false;

        for (int i = 0; i < tokens.Count; i++)
        {
            var token = tokens[i];

            if (token.Type == EType.Number)
            {
                var integer = int.Parse(token.Text);

                if (!leftSideResolved)
                {
                    result.LeftSide = new IntegerElement() {Value = integer};
                    leftSideResolved = true;
                }
                else
                {
                    result.RightSide = new IntegerElement() { Value = integer };
                }
            }

            if (token.Type == EType.Addiction)
            {
                result.TypeOperation = BinaryOperation.ETypeOperation.SUM;
            }
            
            if (token.Type == EType.Subtraction)
            {
                result.TypeOperation = BinaryOperation.ETypeOperation.SUBTRACTION;
            }

            if (token.Type == EType.LeftParenthesis)
            {
                int j = i;

                for (; j < tokens.Count; j++)
                {
                    if (tokens[j].Type == EType.RightParenthesis)
                        break;
                }
                
                var tokensSkipped = tokens.Skip(i + 1).Take(j - i - 1).ToList();
                var element = Parse(tokensSkipped);
                if (!leftSideResolved)
                {
                    result.LeftSide = element;
                    leftSideResolved = true;
                }
                else result.RightSide = element;

                i = j;
            }
        }

        toReturn = new IntegerElement() { Value = result.PerformOperation() };
        return toReturn;
    }
}