using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person person = new Person();
            person.Name = "Fauzi Galih";
            person.Age = 23;
            person.Print();
        }
    }

    struct Person //struct
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Print()
        {
            Console.WriteLine($"My name is {Name} and my age is {Age}");
        }
    }
}
