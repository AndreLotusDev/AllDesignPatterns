using System.Text;

namespace IntrusiveVisitor.Classes
{
    public class DoubleValueExpression : Expression
    {
        private double value;

        public DoubleValueExpression(double value)
        {
            this.value = value;
        }

        public override void Print(StringBuilder sb)
        {
            sb.Append(value);
        }
    }
}
