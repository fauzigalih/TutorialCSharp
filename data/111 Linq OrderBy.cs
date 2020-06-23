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

            var personQueryAsc = from list in lists
                              orderby list.Name ascending
                              select list;

            var personQueryAsc2 = lists.OrderBy(s => s.Name); //Ascending

            var personQueryDesc = from list in lists
                                 orderby list.Name descending
                                 select list;

            var personQueryDesc2 = lists.OrderByDescending(s => s.Name); //Descending

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
