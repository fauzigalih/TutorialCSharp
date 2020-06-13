using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            new Person("Fauzi");
        }
    }

    class Person //can't inherit class User
    {
        User user = new User(); //but can instance class
        public Person(string _fullName)
        {
            user.fullName = _fullName;
            Console.WriteLine($"my name is {user.fullName}");
        }
    }

    sealed class User
    {
        public string fullName;
    }
}
