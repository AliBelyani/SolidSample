using SolidSample.AbstractSample;
using SolidSample.VirtualSample;
using System;

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
        static void Main(string[] args)
        {
            User user = new User();
            user.ShowRole();

            user = new GoldUser();
            user.ShowRole();

            SilverUser silverUser = new SilverUser();
            silverUser.ShowRole();

            user = new BronzeUser();
            user.ShowRole();

            Console.Read();
        }
        #endregion
    }
}