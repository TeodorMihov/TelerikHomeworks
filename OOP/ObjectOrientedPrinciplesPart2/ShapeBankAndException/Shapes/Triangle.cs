namespace ShapeBankAndException.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int width, int height)
            :base(width,height)
        {

        }

        public override double CalculateSufrace()
        {
            return ((base.Height * base.Width) / 2);
        }
    }
}
