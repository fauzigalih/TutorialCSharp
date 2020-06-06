using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Run();
        }

        private static string myName; //private -> only access in this class
        private static void Run()
        {
            Person person = new Person();
            myName = person.name;
            Console.WriteLine("My Name is " + myName);
        }
    }

    class Person : IPerson //class Person Inherit of class IPerson
    {
        public string name = _name; //public -> can access in all class
    }

    class IPerson //Interface or parrent of Person
    {
        protected static string _name = "Fauzi Galih"; //protected -> can access of child class and this class
    }
}
