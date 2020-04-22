using SolidSample.AbstractSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Teacher();
            person.ShowInfo();

            person = new Student();
            person.ShowInfo();

            Console.Read();
        }
    }
}