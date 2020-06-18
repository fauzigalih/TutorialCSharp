using System; //library
using System.Collections.Generic;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person search = new Person();
            person1.Name = "Fauzi";
            person2.Name = "Fauzi Galih";

            Console.Write("Search? ");
            search.Name = Console.ReadLine();

            List<Person> persons = new List<Person>() { person1, person2 };

            Console.WriteLine(Person.GetListName(persons, search));

            if(Person.GetListName(persons, search) == null)
            {
                Console.WriteLine("Not Found");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public static Person GetListName(List<Person> persons, Person search)
        {
            foreach(Person p in persons)
            {
                if(p.Equals(search)) return p;
            }
            return null;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (Name == ((Person)obj).Name) return true;
            
            return false;
        }
    }
}
