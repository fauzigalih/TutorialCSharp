using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            User user = new User();
            user.Name = "Fauzi Galih";
            user.Print();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public virtual void Print()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }

    class User : Person
    {
        public override void Print()
        {
            Console.WriteLine($"My name is {Name} and type is {Name.GetType()}");
        }
    }
}
