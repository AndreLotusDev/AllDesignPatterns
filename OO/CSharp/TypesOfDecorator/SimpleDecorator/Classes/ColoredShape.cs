namespace SimpleDecorator.Classes
{
    public class ColoredShape : Shape
    {
        private readonly Shape _shape;
        private readonly string _color;

        public ColoredShape(Shape shape, string color)
        {
            _shape = shape;
            _color = color;
        }

        public string AsString()
        {
            return $"This is a shape with the color {_color} {_shape.AsString()}";
        }
    }
}
