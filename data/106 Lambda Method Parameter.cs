using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Run(5, 6);
        }

        static void Run(int x, int y) => Console.WriteLine(x + y);
    }
}
