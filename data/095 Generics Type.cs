using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person<string> person1 = new Person<string>();
            person1.FullName = "Fauzi Galih";

            Person<int> person2 = new Person<int>();
            person2.Age = 23;

            Console.WriteLine($"My name is {person1.GetFullName()} and my age is {person2.GetAge()}");
        }
    }

    class Person<T>
    {
        public T FullName { get; set; }
        public T Age { get; set; }
        public T GetFullName()
        {
            return FullName;
        }

        public T GetAge()
        {
            return Age;
        }
    }
}
