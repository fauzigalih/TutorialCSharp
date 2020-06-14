using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            new Person<string>("Fauzi Galih");
            new Person<int>(23);
            new Person<bool>(true);
        }
    }

    class Person<T>
    {
        public Person(T person)
        {
            Console.WriteLine(person);
        }
    }
}
