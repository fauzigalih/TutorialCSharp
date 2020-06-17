using System; //library
using System.Collections.Generic;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            List<Person> persons = new List<Person>(); //create list
            Username();
            Console.Write("Need to create username again? (y/n) : ");
            string answer = Console.ReadLine().ToUpper();

            while (answer == ConsoleKey.Y.ToString())
            {
                ListUsername();
                Username();
                Console.Write("Need to create username again? (y/n) : ");
                string answerLoop = Console.ReadLine().ToUpper();
                if (answerLoop == ConsoleKey.N.ToString())
                {
                    ListUsername();
                    return;
                }
            }

            while(answer == ConsoleKey.N.ToString())
            {
                ListUsername();
                return;
            }

            void Username()
            {
                Person person = new Person();
                Console.WriteLine("Create Your username is here : ");
                Console.Write("Your First Name ? ");
                person.FirstName = Console.ReadLine();
                Console.Write("Your Last Name ? ");
                person.LastName = Console.ReadLine();
                Console.WriteLine("Your username is : " + person.FullName + "\nThank You..");
                persons.Add(person);
            }

            void ListUsername()
            {
                Console.WriteLine("List Username is : ");
                foreach(var username in persons)
                {
                    Console.WriteLine(username.FullName);
                }
            }
            
        }
    }

    class Person
    {
        public  string FullName
        {
            get
            {
                return (FirstName + LastName).ToLower(); //getter
            }
        }

        public string FirstName { get; set; } //custom getter and setter property

        public string LastName { get; set; } //custom getter and setter property
    }
}
