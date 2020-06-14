using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person<string, int> person = new Person<string, int>();
            person.Name = "Fauzi";

            User user = new User();
            person.Age = user.Age();
            Console.WriteLine($"My name is {person.Name} and my age is {person.Age}");
        }

        struct User
        {
            public int Age()
            {
                Person<string, int> person = new Person<string, int>();
                person.Age = 20;
                return 20;
            }
        }
    }

    class Person<T, U> where T: class where U: struct
    {
        public T Name { get; set; }
        public U Age { get; set; }
    }
}
