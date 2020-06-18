using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person person = new Person();

            //Value Type
            int x = 10;
            person.Post(x);
            Console.WriteLine(x);

            //Reference Type
            person.Name = "Fauzi";
            person.Print(person);
            Console.WriteLine(person.Name);
        }
    }

    class Person
    {
        public string Name { get; set; }

        public void Print(Person person)
        {
            person.Name += " Galih";
        }

        public int Post(int post)
        {
            return 100;
        }
    }
}
