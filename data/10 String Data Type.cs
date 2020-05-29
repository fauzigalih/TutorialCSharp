using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            string name = "Fauzi"; //varibale string
            name.ToLower(); //output -> fauzi
            name.ToUpper(); //output -> FAUZI
            name += " Galih"; //String concatenation
            int length = name.Length; //can found length property from string
            string message = $"My name is {name} with length characters is {length}"; //String Interpolation
            Console.WriteLine(message); //print statement of string message
        }
    }

}
