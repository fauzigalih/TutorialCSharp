using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Run();
            Running();
        }

        static void Run()
        {
            Console.WriteLine("This is basic");
        }

        static void Running() => Console.WriteLine("This with Lambda Expression");
    }
}
