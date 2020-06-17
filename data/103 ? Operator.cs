using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int? a = null; //can assign null value
            int b = 5;
            Console.WriteLine($"a: {a} \nb: {b}");
            a = 10;
            Console.WriteLine($"a: {a} \nb: {b}");

            Print(null);
            Print("Fauzi Galih");
        }

        static void Print(string? name)
        {
            Console.WriteLine($"My name is {name}");
        }
    }
}
