using System.Text;

namespace ReflectiveVisitor.Classes
{
    public class DoubleValueExpression : Expression
    {
        public double Value;

        public DoubleValueExpression(double value)
        {
            Value = value;
        }

        public override void Print(StringBuilder sb)
        {
            sb.Append(Value);
        }


    }
}
