using System; //library

namespace TutorialCSharp //namespace
{
    class Program : Person //class inheritance of class Person
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Run();
        }
    }

    class Person
    {
        public static void Run()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
