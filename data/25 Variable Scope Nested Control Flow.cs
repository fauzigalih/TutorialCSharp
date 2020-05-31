using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static int x = 5; //variable int global
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Nested For Loop
            Program.Test();
            x = 6;
            Console.WriteLine(x);
            Program.Test();
        }

        static void Test()
        {
            Console.WriteLine(x);
        }
    }
}
