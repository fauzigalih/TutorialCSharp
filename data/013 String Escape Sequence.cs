using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //String Escape Squences
            Console.WriteLine("Fauzi\tGalih"); //tab -> \t
            Console.WriteLine("Fauzi\nGalih"); //new line -> \n
            Console.WriteLine("Fauzi\\Galih"); //backslash -> \\
            Console.WriteLine("Fauzi\bGalih"); //backspace -> \b
            Console.WriteLine("Fauzi\"Galih\"");  //double quote -> \"

            //Any more for Escape Squence in link: https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2019
        }
    }
}
