namespace SolidSample.OCP
{
    public class Square : Shape
    {
        public double Width { get; set; }

        public override double Area()
        {
            return Width * Width;
        }
    }
}
