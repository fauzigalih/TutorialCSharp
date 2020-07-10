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
            IList<string> strList = new List<string>() { "Satu", "Dua", "Tiga", "Empat", "Lima" };

            List<Person> persons = new List<Person>()
            {
                new Person(){PersonID = 1, Name = "Fauzi Galih", Age = 23},
                new Person(){PersonID = 2, Name = "Galih", Age = 24},
                new Person(){PersonID = 3, Name = "Pitak B Otak", Age = 29},
                new Person(){PersonID = 4, Name = "Keleb", Age = 26}
            };

            //Aggregate
            string strListComma = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(strListComma);

            string personListComma = persons.Aggregate("Daftar Nama: ", (str, s) => str += s.Name + ", ");
            string personListComma1 = persons.Aggregate<Person, string>("Daftar Nama: ", (str, s) => str += s.Name + ", ");
            Console.WriteLine(personListComma);

            string personList = persons.Aggregate(string.Empty, (str, s) => str += s.Name + ", ", str => str.Substring(0, str.Length -2));
            string personList1 = persons.Aggregate<Person, string, string>(String.Empty, (str, s) => str += s.Name + ", ", str => str.Substring(0, str.Length -2));
            Console.WriteLine(personList);

            int personAgeSum = persons.Aggregate(0, (totalAge, s) => totalAge += s.Age);
            int personAgeSum1 = persons.Aggregate<Person, int>(0, (totalAge, s) => totalAge += s.Age);
            Console.WriteLine(personAgeSum);
        }
    }

    class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
