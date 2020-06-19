using System; //library

namespace TutorialCSharp //namespace
{
    class Program : Person //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person person = new Person();
            User user = new User();

            person.Print();
            user.Print();
        }

        //you cant use override Print sealed in class Person
        //public override void Print() {...}
    }

    class Person : User
    {
        public sealed override void Print()
        {
            Console.WriteLine("This is class person sealed");
        }
    }

    class User
    {
        public virtual void Print()
        {
            Console.WriteLine("This is class user");
        }
    }
}
