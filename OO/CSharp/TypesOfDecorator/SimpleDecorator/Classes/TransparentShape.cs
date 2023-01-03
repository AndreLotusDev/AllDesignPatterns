namespace SimpleDecorator.Classes
{
    public class TransparentShape : Shape
    {
        private readonly Shape _shape;
        private readonly int _transparency;

        public TransparentShape(Shape shape, int transparency)
        {
            _shape = shape;
            _transparency = transparency;
        }
        public string AsString()
        {
            return $"This shape have a transparency of {_transparency}% {_shape.AsString()}";
        }
    }
}
