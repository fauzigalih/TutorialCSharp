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
            List<Person> lists = new List<Person>()
            {
                new Person(){Name = "Fauzi", Age = 23},
                new Person(){Name = "Galih", Age = 24},
                new Person(){Name = "Pitak", Age = 29},
                new Person(){Name = "Keleb", Age = 26}
            };

            var personQueryAsc = lists.OrderBy(s => s.Name).ThenBy(s => s.Age);

            var personQueryDesc = lists.OrderBy(s => s.Name).ThenByDescending(s => s.Age); 

            Console.WriteLine("Ascending :");
            foreach (var i in personQueryAsc) Console.WriteLine(i.Name + " and " + i.Age);
            Console.WriteLine("Descending :");
            foreach (var i in personQueryDesc) Console.WriteLine(i.Name + " and " + i.Age);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
