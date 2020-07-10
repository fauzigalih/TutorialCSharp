using System; //library
using System.Collections.Generic;
using System.Linq;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            QueryList();
        }

        static void QueryList()
        {
            List<Person> persons = new List<Person>()
            {
                new Person(){PersonID = 1, Name = "Fauzi Galih", Age = 23},
                new Person(){PersonID = 2, Name = "Galih", Age = 24},
                new Person(){PersonID = 3, Name = "Pitak B Otak", Age = 29},
                new Person(){PersonID = 4, Name = "Keleb", Age = 26}
            };

            //All
            bool personAgeAll = persons.All(a => a.Age > 20 && a.Age < 30); //true
            Console.WriteLine(personAgeAll);

            //Any
            bool personAgeAny = persons.Any(a => a.Age == 26); //true
            Console.WriteLine(personAgeAny);
        }
    }

    class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
