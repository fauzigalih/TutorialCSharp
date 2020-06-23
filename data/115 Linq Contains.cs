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
            List<int> numbers = new List<int>() { 2, 32, 4, 5 };
            var containsNumber = numbers.Contains(2); //true
            Console.WriteLine(containsNumber);

            List<Person> persons = new List<Person>()
            {
                new Person(){PersonID = 1, Name = "Fauzi Galih", Age = 23},
                new Person(){PersonID = 2, Name = "Galih", Age = 24},
                new Person(){PersonID = 3, Name = "Pitak B Otak", Age = 29},
                new Person(){PersonID = 4, Name = "Keleb", Age = 26}
            };

            var containsPerson = from person in persons
                                 where person.Name.Contains("Galih")
                                 select person;

            foreach (var i in containsPerson) Console.WriteLine(i.Name);
        }
    }

    class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
