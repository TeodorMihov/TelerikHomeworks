namespace ShapeBankAndException
{

    public abstract class Shape
    {
        public Shape(int width)
        {
            this.Width = width;
        }

        public Shape(int width, int height)
            :this(width)
        {
            this.Height = height;
        }
        public int Width { get; private set; }

        public int Height { get; private set; }

        public abstract double CalculateSufrace();
    }
}
