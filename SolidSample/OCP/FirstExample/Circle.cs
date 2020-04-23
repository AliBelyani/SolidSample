using System;

namespace SolidSample.OCP
{
    public class Circle : Shape
    {
        public Circle(double radios)
        {
            this.Radios = radios;
        }

        public double Radios { get; set; }

        public override double Area()
        {
            return Radios * Radios * Math.PI; ;
        }
    }
}
