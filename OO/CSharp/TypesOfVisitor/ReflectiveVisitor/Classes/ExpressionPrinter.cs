using System.Text;

namespace ReflectiveVisitor.Classes
{
    public static class ExpressionPrinter
    {
        private static Dictionary<Type, Action<Expression, StringBuilder>> DictType = new()
        {
            [typeof(DoubleValueExpression)] = (e, sb) =>
            {
                var expression = e as DoubleValueExpression;

                sb.Append(expression.Value);
            },

            [typeof(AdditionExpression)] = (e, sb) =>
            {
                var expression = e as AdditionExpression;

                sb.Append("(");
                expression.Left.Print(sb);
                sb.Append("+");
                expression.Right.Print(sb);
                sb.Append(")");
            }
        };

        public static void Print(Expression ex, StringBuilder sb)
        {
            if (DictType.TryGetValue(ex.GetType(), out var action))
            {
                action(ex, sb);
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
