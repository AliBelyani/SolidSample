using System;

namespace SolidSample.VirtualSample
{
    public class User
    {
        public virtual void ShowRole()
        {
            Console.WriteLine("This is Admin User");
        }
    }

    public class GoldUser : User
    {
        public override void ShowRole()
        {
            Console.WriteLine("This is Gold User");
        }
    }

    public class SilverUser : User
    {

    }

    public class BronzeUser : User
    {
        public override void ShowRole()
        {
            Console.WriteLine("This is Bronze User");
        }
    }
}
