namespace SolidSample.OCP
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
