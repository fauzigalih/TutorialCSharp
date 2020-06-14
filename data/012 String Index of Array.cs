using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            string name = "Fauzi Galih"; //variable string
            string[] arr = name.Split(' '); //convert string to array -> output: ["Fauzi", "Galih"]
            char f = name[0]; //convert string to char with index of array string -> output: F
            //Console.WriteLine(f);
            Console.WriteLine("My name is {0}.", name); //index of array string -> replace index {0} with name
            Console.WriteLine("My name is {0}, and length my name is {1}.", name, name.Length); //replace index {0} with name and {1} with name.Length
        }
    }
}
