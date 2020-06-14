using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person<string> person = new Person<string>();
            person.Name = "Fauzi";
            Console.WriteLine(person.Name);

            Name name = new Name();
            Console.WriteLine(name.Print());
        }
        struct Name
        {
            public int Print()
            {
                User<int> user = new User<int>();
                user.Test = 20;
                return user.Test;
            }
        }
    }

    class Person<T> where T: class
    {
        public T Name { get; set; }
    }

    class User<U> where U: struct
    {
        public U Test { get; set; }
    }
}
