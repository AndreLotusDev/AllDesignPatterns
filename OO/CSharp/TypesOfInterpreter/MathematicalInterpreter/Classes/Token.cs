namespace MathematicalInterpreter.Classes;

public class Token
{
    public EType Type { get; set; }
    public string Text { get; set; }

    public override string ToString()
    {
        return Text.ToString(); 
    }
}

public enum EType
{
    Addiction,
    Subtraction,
    Multiplication,
    Division,
    LeftParenthesis,
    RightParenthesis,
    Number
}