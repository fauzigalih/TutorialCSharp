using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person person = new Person();
            person.Print();
        }
    }

    class Person
    {
        public Person() //constructor struct
        {
            Console.WriteLine("Constructor");
        }
        public string Name { get; set; } = "Fauzi Galih";
        public int Age { get; set; } = 23;
        public void Print()
        {
            Console.WriteLine($"My name is {Name} and my age is {Age}");
        }

        ~Person()
        {
            Console.WriteLine("Destructor");
        }
    }
}
