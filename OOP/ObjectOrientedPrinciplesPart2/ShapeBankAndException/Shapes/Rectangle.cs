namespace ShapeBankAndException.Shapes
{
    public class Rectangle : Shape
    {

        public Rectangle(int width, int height)
            : base(width, height)
        {

        }

        public override double CalculateSufrace()
        {
            return base.Height * base.Width;
        }
    }
}
