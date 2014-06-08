namespace ShapeBankAndException.Shapes
{
    public class Circle : Shape
    {
        public Circle(int radius)
            :base(radius)
        {

        }
        
        public override double CalculateSufrace()
        {
            return base.Width * base.Width * System.Math.PI;
        }
    }
}
