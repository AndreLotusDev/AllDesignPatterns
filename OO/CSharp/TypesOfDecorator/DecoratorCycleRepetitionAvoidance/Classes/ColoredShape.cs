namespace DecoratorCycleRepetitionAvoidance.Classes
{
    public class ColoredShape : ShapeDecorator<ColoredShape, SkipRepeatedDecorator>
    {
        private readonly Shape _shape;
        private readonly string _color;

        public ColoredShape(Shape shape, string color) : base(shape)
        {
            _shape = shape;
            _color = color;
        }

        public override string AsString()
        {
            if (shapes.Contains(this))
            {
                return $"This is a shape with the color {_color} {_shape.AsString()}";
            }
            else
            {
                return $"{_shape.AsString()}";
            }
        }
    }
}
