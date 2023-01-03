namespace DecoratorCycleRepetitionAvoidance.Classes
{
    public class Square : Shape
    {
        public int Area { get; set; }
        public Square() : this(10)
        {
            
        }
        public Square(int area) 
        {
            Area = area;
        }
        public override string AsString()
        {
            return $"This is a square with area of {Area * Area}";
        }
    }
}
