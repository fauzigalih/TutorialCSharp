using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program program = new Program();
            Console.WriteLine(program.fullName);
            Console.WriteLine(program.FullName);
            program.GetFullName();

            new Person("Fauzi");
        }

        private readonly string fullName = "Fauzi Galih";
        public string FullName { get { return fullName; } }
        public void GetFullName()
        {
            Console.WriteLine(FullName);
        }
    }

    class Person
    {
        public readonly string fullName;
        public Person(string _fullName)
        {
            fullName = _fullName;
            Console.WriteLine($"my name is {fullName}");
        }
    }
}
