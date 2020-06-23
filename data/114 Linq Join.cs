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
            List<int> numbers1 = new List<int>() { 2, 3, 4 };
            List<int> numbers2 = new List<int>() { 2, 3, 5, 6 };
            var numbersJoin = numbers1.Join(numbers2,
                n1 => n1,
                n2 => n2,
                (n1, n2) => n1);
            foreach (var i in numbersJoin) Console.WriteLine(i);

            List<Person> persons = new List<Person>()
            {
                new Person(){PersonID = 1, Name = "Fauzi", Age = 23},
                new Person(){PersonID = 2, Name = "Galih", Age = 24},
                new Person(){PersonID = 3, Name = "Pitak", Age = 29},
                new Person(){PersonID = 4, Name = "Keleb", Age = 26}
            };

            List<Item> items = new List<Item>()
            {
                new Item() {ItemID = 1, ItemName = "Book"},
                new Item() {ItemID = 2, ItemName = "Pen"},
                new Item() {ItemID = 3, ItemName = "Ransel"},
                new Item() {ItemID = 4, ItemName = "Pencil"},
            };

            var innerJoin = persons.Join(
                items,
                person => person.PersonID,
                item => item.ItemID,
                (person, item) => new
                {
                    Name = person.Name,
                    ItemName = item.ItemName,
                });
            foreach (var i in innerJoin) Console.WriteLine(i);
            Console.WriteLine("String :");
            foreach (var i in innerJoin) Console.WriteLine($"{i.Name} and {i.ItemName}");
        }
    }

    class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
    }
}
