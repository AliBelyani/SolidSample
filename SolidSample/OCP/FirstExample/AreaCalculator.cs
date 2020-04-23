using System;
using System.Collections.Generic;

namespace SolidSample.OCP
{
    public class AreaCalculator
    {
        //public double Area(object[] shapes)
        //{
        //    double area = 0;
        //    foreach (var shape in shapes)
        //    {
        //        if (shape is Rectangle)
        //        {
        //            Rectangle rectangle = (Rectangle)shape;
        //            area += rectangle.Height * rectangle.Width;
        //        }
        //        else if (shape is Circle)
        //        {
        //            Circle circle = (Circle)shape;
        //            area += circle.Radios * circle.Radios * Math.PI;
        //        }
        //        else
        //        {
        //            Square square = (Square)shape;
        //            area += square.Width * square.Width;
        //        }
        //    }

        //    return area;
        //}

        public double Area(List<Shape> shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
                area += shape.Area();

            return area;
        }
    }
}
