using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Single Line If Statement
            Console.Write("What is my fullname? ");
            string checkName = Console.ReadLine().ToLower();
            string name = "Fauzi Galih".ToLower();
            if (name == checkName) Console.WriteLine("Yes, Its me. Im Fauzi Galih.");

            if (name != checkName) Console.WriteLine("No, Its not me.");
        }
    }
}
