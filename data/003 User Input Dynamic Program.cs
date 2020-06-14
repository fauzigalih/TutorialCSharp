using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Console.Write("Enter your name : "); //statement without new line
            string name = Console.ReadLine(); //initialization variable name and assign with input type
            Console.WriteLine("Your name is " + name); //statement concat with variable name (input type)
        }
    }
}
