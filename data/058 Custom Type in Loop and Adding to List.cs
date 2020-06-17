using System; //library
using System.Collections.Generic;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            List<Person> persons = new List<Person>(); //create list
            List<string> firstNames = new List<string>() { "Fauzi", "Visual", "C#" };
            List<string> lastNames = new List<string>() { "Galih", "Studio", "" };
            
            for(int i = 0; i < firstNames.Count; i++)
            {
                Person person = new Person();
                person.FirstName = firstNames[i];
                person.LastName = lastNames[i];
                persons.Add(person);
            }

            foreach(var username in persons)
            {
                Console.WriteLine(username.FullName);
            }
        }
    }

    class Person
    {
        public  string FullName
        {
            get
            {
                return FirstName + " " + LastName; //getter
            }
        }

        public string FirstName { get; set; } //custom getter and setter property

        public string LastName { get; set; } //custom getter and setter property
    }
}
