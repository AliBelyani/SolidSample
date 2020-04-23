using SolidSample.AbstractSample;
using SolidSample.OCP;
using SolidSample.VirtualSample;
using System;
using System.Collections.Generic;

namespace SolidSample
{
    class Program
    {
        #region Abstract Methods
        //static void Main(string[] args)
        //{
        //    Person person = new Teacher();
        //    person.ShowInfo();

        //    Student student = new Student();
        //    student.ShowInfo();

        //    Console.Read();
        //} 
        #endregion

        #region Virtual Methods
        //static void Main(string[] args)
        //{
        //    User user = new User();
        //    user.ShowRole();

        //    user = new GoldUser();
        //    user.ShowRole();

        //    SilverUser silverUser = new SilverUser();
        //    silverUser.ShowRole();

        //    user = new BronzeUser();
        //    user.ShowRole();

        //    Console.Read();
        //}
        #endregion

        #region OCP
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 4);
            Circle circle = new Circle(3);

            AreaCalculator areaCalculator = new AreaCalculator();
            var shapes = new List<Shape> { rectangle, circle };

            double area = areaCalculator.Area(shapes);
            Console.WriteLine(area);
            Console.Read();
        }
        #endregion
    }
}