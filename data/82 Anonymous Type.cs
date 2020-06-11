using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Anonymous Type -> var
            var x = 5;
            var y = "Fauzi Galih";
            Console.WriteLine($"Value x is {x} and type is {x.GetType()}");
            Console.WriteLine($"Value x is {y} and type is {y.GetType()}");
        }
    }
}
