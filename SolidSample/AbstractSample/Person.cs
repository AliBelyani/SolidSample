using System;

namespace SolidSample.AbstractSample
{
    public abstract class Person
    {
        public abstract void ShowInfo();
    }

    public class Teacher : Person
    {
        public override void ShowInfo()
        {
            Console.WriteLine("This is Teacher");
        }
    }

    public class Student : Person
    {
        public override void ShowInfo()
        {
            Console.WriteLine("This is Student");
        }
    }
}
