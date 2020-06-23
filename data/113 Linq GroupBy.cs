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

            var groupQuery = from list in lists
                             group list by list.Age;

            var groupQuery2 = lists.GroupBy(s => s.Age); //simple

            foreach(var group in groupQuery)
            {
                Console.WriteLine(group.Key);
                foreach(var grp in group)
                {
                    Console.WriteLine(grp.Name);
                }
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
