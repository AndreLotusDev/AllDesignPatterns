namespace DecoratorCycleRepetitionAvoidance.Classes
{
    public abstract class ShapePolicy
    {
        public abstract bool Handle(Type actualType, List<Type> allTypes, ref List<Shape> shapes);
    }

    public class ThrowErrorIfMoreThanOnePolicy : ShapePolicy
    {
        public override bool Handle(Type actualType, List<Type> allTypes, ref List<Shape> shapes)
        {
            if (allTypes.Contains(actualType))
            {
                throw new InvalidOperationException($"This type decorator was already used {actualType.Name}");
            }

            return true;
        }
    }

    public class SkipRepeatedDecorator : ShapePolicy
    {
        public override bool Handle(Type actualType, List<Type> allTypes, ref List<Shape> shapes)
        {
            shapes = SkipRepeated(ref shapes);

            return true;
        }

        public List<Shape> SkipRepeated(ref List<Shape> shapes)
        {
            return shapes.DistinctBy(d => d.GetType()).ToList();
        }
    }

}
