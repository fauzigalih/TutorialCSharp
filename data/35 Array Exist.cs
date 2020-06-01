using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            string[] names = { "Fauzi", "Galih" }; //array
            bool exist = Array.Exists(names, element => element == "Fauzi"); //method array exist -> true or false
            if (exist) Console.WriteLine("Its my first name.."); //condition array exist
            else Console.WriteLine("Not my name..");
        }
    }
}
