namespace MathematicalInterpreter.Classes;

public class BinaryOperation
{
    public IntegerElement LeftSide { get; set; }
    public IntegerElement RightSide { get; set; }
    public ETypeOperation TypeOperation { get; set; }

    public enum ETypeOperation
    {
        SUM,
        SUBTRACTION,
        MULTIPLICATION,
        DIVISION
    } 
    
    public int PerformOperation()
    {
        if (TypeOperation == ETypeOperation.SUM)
        {
            return LeftSide.Value + RightSide.Value;
        }
        else if (TypeOperation == ETypeOperation.SUBTRACTION)
        {
            return LeftSide.Value - RightSide.Value;
        } 
        else if (TypeOperation == ETypeOperation.MULTIPLICATION)
        {
            throw new NotImplementedException("We don't support multiplication operations");
        }
        else
        {
            throw new NotImplementedException("We don't support division operations");
        }
    }
}