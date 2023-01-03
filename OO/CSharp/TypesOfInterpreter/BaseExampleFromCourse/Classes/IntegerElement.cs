namespace BaseExampleFromCourse.Classes
{
    public class IntegerElement : IElement
    {
        public IntegerElement(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }
}
