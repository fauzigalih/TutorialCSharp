using System; //library
using System.Collections.Generic;
using System.Linq;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            QueryStringArray();
            QueryList();
        }

        static void QueryStringArray()
        {
            string[] names =
            {
                "Fauzi", "Galih", "John", "Siwer","Keleb", "Odon", "Kepet"
            };

            var nameStat = from name in names
                           where name.Contains("a")
                           select name; //select
            foreach(var name in nameStat)
            {
                Console.WriteLine(name);
            }
        }

        static void QueryList()
        {
            List<Person> persons = new List<Person>()
            {
                new Person(){Name = "Fauzi", Age = 23},
                new Person(){Name = "Galih", Age = 24}
            };

            var personQuery = from person in persons
                              where person.Age == 23
                              select person;

            foreach (var i in personQuery) Console.WriteLine(i.Name + " and " + i.Age);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
