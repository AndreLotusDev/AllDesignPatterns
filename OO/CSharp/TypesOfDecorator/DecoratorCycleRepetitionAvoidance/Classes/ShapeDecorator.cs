namespace DecoratorCycleRepetitionAvoidance.Classes
{
    public abstract class ShapeDecorator : Shape
    {
        private readonly Shape _shape;
        public readonly List<Type> types = new();
        public List<Shape> shapes = new();

        public ShapeDecorator(Shape shape)
        {
            _shape = shape;

            if (_shape is ShapeDecorator sd)
            {
                types.AddRange(sd.types);
                shapes.AddRange(sd.shapes);
            }
        }
    }

    public abstract class ShapeDecorator<TSelf, TPolicy> : ShapeDecorator where TPolicy : ShapePolicy, new()
    {
        protected readonly TPolicy _policy = new();
        public ShapeDecorator(Shape shape) : base(shape)
        {
            shapes.Add(this);
            _policy.Handle(shape.GetType(), types, ref shapes);
            types.Add(typeof(TSelf));
        }
    }
}
