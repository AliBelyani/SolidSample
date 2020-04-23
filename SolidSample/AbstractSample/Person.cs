using System;

namespace SolidSample.AbstractSample
{
    public abstract class Person
    {
        public abstract void ShowInfo();

        public void ShowName()
        {
            Console.WriteLine("My Name Is Ali");
        }
    }

    public class Student : Person
    {
        public override void ShowInfo()
        {
            Console.WriteLine("This is Student");
        }
    }

    public class Teacher : Person
    {
        public override void ShowInfo()
        {
            Console.WriteLine("This is Teacher");
        }
    }
}
