using System; //library
using System.Collections;
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
            IList lists = new ArrayList()
            {
                new Person(){Name = "Fauzi", Age = 23},
                new Person(){Name = "Galih", Age = 24},
                2, 3, 5,
                "Fauzi", "Galih"
            };

            var stringQuery = from list in lists.OfType<string>()
                              select list;

            var intQuery = from list in lists.OfType<int>()
                           select list;

            var personQuery = from list in lists.OfType<Person>()
                              select list;

            foreach (var i in stringQuery) Console.WriteLine(i);
            foreach (var i in intQuery) Console.WriteLine(i);
            foreach (var i in personQuery) Console.WriteLine(i.Name + " and " + i.Age);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
