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
            IList<int> numbers = new List<int>() { 2, 3, 5, 7 };

            List<Person> persons = new List<Person>()
            {
                new Person(){PersonID = 1, Name = "Fauzi Galih", Age = 23},
                new Person(){PersonID = 2, Name = "Galih", Age = 24},
                new Person(){PersonID = 3, Name = "Pitak B Otak", Age = 29},
                new Person(){PersonID = 4, Name = "Keleb", Age = 26}
            };

            //Average
            double numAverage = numbers.Average();
            Console.WriteLine(numAverage);

            double ageAverage = persons.Average(s => s.Age);
            Console.WriteLine(ageAverage);
        }
    }

    class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
