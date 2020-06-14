using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person<string, int> person = new Person<string, int>();
            person.Name = "Fauzi";
            person.Age = 23;
            Console.WriteLine($"My name is {person.Name} and my age is {person.Age}");
        }
    }

    class Person<T, U>
    {
        public T Name { get; set; }
        public U Age { get; set; }
    }
}
