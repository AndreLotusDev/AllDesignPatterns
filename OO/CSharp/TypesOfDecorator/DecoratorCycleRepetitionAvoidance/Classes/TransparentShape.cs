namespace DecoratorCycleRepetitionAvoidance.Classes
{
    public class TransparentShape : ShapeDecorator<ColoredShape, SkipRepeatedDecorator>
    {
        private readonly Shape _shape;
        private readonly int _transparency;

        public TransparentShape(Shape shape, int transparency) : base(shape)
        {
            _shape = shape;
            _transparency = transparency;
        }
        public override string AsString()
        {
            return $"This shape have a transparency of {_transparency}% {_shape.AsString()}";
        }
    }
}
